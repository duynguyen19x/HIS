using HIS.ApplicationService.Authorization.Dto;
using HIS.ApplicationService.Authorization.Dtos;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Transactions;

namespace HIS.ApplicationService.Authorization
{
    public class AuthorizationAppService : BaseAppService, IAuthorizationAppService
    {
        private readonly IRepository<User, Guid> _userRepository;
        private readonly IRepository<UserToken, Guid> _userTokenRepository;
        private readonly IRepository<UserRoleMapping, Guid> _userRoleMappingRepository;
        private readonly IRepository<Role, Guid> _roleRepository;
        private readonly IConfiguration _config;

        public AuthorizationAppService(
            IRepository<User, Guid> userRepository,
            IRepository<UserToken, Guid> userTokenRepository,
            IRepository<UserRoleMapping, Guid> userRoleMappingRepository,
            IRepository<Role, Guid> roleRepository,
            IConfiguration config)
        {
            _userRepository = userRepository;
            _userTokenRepository = userTokenRepository;
            _userRoleMappingRepository = userRoleMappingRepository;
            _roleRepository = roleRepository;
            _config = config;
        }

        public async Task<ResultDto<LoginResultDto>> LoginAsync(LoginDto request)
        {
            var result = new ResultDto<LoginResultDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var user = await _userRepository.FirstOrDefaultAsync(x => x.Inactive == false 
                        && x.Username.ToUpper() == request.Username.ToUpper() && x.Password.ToUpper() == request.Password.ToUpper());  
                    if (user == null)
                    {
                        throw new Exception("Tài khoản hoặc mật khẩu không đúng!");
                    }

                    var acceptToken = await CreateTokenAsync(await CreateClaimsAsync(user), AppConst.AcceptTokenExpiration);
                    var refreshToken = await CreateTokenAsync(await CreateClaimsAsync(user, TokenTypes.RefreshToken), AppConst.RefreshTokenExpiration);

                    var loginResult = new LoginResultDto()
                    {
                        User = ObjectMapper.Map<UserDto>(user),
                        AccessToken = new JwtSecurityTokenHandler().WriteToken(acceptToken),
                        RefreshToken = new JwtSecurityTokenHandler().WriteToken(refreshToken),
                        ExpireDate = Convert.ToInt64(acceptToken.ValidTo.ToLocalTime().ToString("yyyyMMddHHmmss")),
                        TokenType = ""
                    };

                    // Save token
                    var sToken = new UserToken()
                    {
                        Id = Guid.NewGuid(),
                        UserId = user.Id,
                        TokenValue = loginResult.RefreshToken,
                        Jti = acceptToken.Id,
                        IsUsed = false,
                        IsRevoked = false,
                        IssueAt = refreshToken.ValidFrom,
                        ExpiredAt = refreshToken.ValidTo,
                    };
                    await _userTokenRepository.InsertAsync(sToken);

                    // Lưu thông tin đăng nhập
                    SessionExtensions.Login = new LoginSecsion
                    {
                        Id = user.Id,
                        UserName = user.Username
                    };

                    unitOfWork.Complete();
                    result.Success(loginResult);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<RefreshTokenResultDto>> RefreshTokenAsync(RefreshTokenDto input)
        {
            var result = new ResultDto<RefreshTokenResultDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    if (string.IsNullOrEmpty(input.RefreshToken))
                    {
                        throw new Exception("Refresh token is not valid!");
                    }

                    var key = Encoding.UTF8.GetBytes(_config["Tokens:Key"]);
                    string issuer = _config["Tokens:Issuer"];

                    // Check valid format
                    var tokenInVerification = new JwtSecurityTokenHandler().ValidateToken(input.AccessToken, new TokenValidationParameters()
                    {
                        // Tự cấp token
                        ValidateIssuer = true,
                        ValidateAudience = true,

                        // Ký vào token
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),

                        // Set thời gian
                        ClockSkew = TimeSpan.Zero,
                        ValidateLifetime = false, // không kiểm tra hết hạn

                        ValidIssuer = issuer,
                        ValidAudience = issuer,

                    }, out var validatedToken);

                    // Kiểm tra thuật toán
                    if (validatedToken is JwtSecurityToken jwtSecurityToken)
                    {
                        var isCheckToken = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512, StringComparison.InvariantCultureIgnoreCase);
                        if (!isCheckToken)
                        {
                            throw new Exception("Invalid token");
                        }
                    }

                    // Check acceptToken đã hoạt động chưa
                    var utcExpireDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(f => f.Type == JwtRegisteredClaimNames.Exp).Value);
                    if (ConvertUnixTimeToDateTime(utcExpireDate) >= DateTime.UtcNow)
                    {
                        throw new Exception("The access token has expired!");
                    }

                    // Kiểm tra refreshToken có trong database ko?
                    var storedToken = _userTokenRepository.FirstOrDefault(x => x.TokenValue == input.RefreshToken); // Context.Tokens.Where(w => w.TokenValue == token.RefreshToken).FirstOrDefault(); // RefreshToken = RefreshToken trong database
                    if (storedToken == null)
                    {
                        throw new Exception("Refresh token does not exist!");
                    }
                    else
                    {
                        // Kiểm tra hạn sử dụng
                        if (storedToken.ExpiredAt < DateTime.Now)
                        {
                            throw new Exception("Refresh token token has expired!");
                        }

                        // Kiểm tra refreshToken đã sử dụng chưa
                        if (storedToken.IsUsed)
                        {
                            throw new Exception("Refresh token has been used!");
                        }

                        // Kiểm tra refreshToken đã thu hổi chưa
                        if (storedToken.IsRevoked)
                        {
                            throw new Exception("Refresh token has been revoked!");
                        }
                    }

                    // Kiểm tra Id có trong RefreshToken 
                    var jti = tokenInVerification.Claims.FirstOrDefault(f => f.Type == JwtRegisteredClaimNames.Jti).Value;
                    if (storedToken.Jti != jti)
                    {
                        throw new Exception("Token doesn't match!");
                    }

                    // Tạo token mới
                    var userById = _userRepository.FirstOrDefault(x => x.Id == storedToken.UserId); // Context.User.FirstOrDefault(f => f.Id == storedToken.UserId.GetValueOrDefault());
                    var acceptToken = await CreateTokenAsync(await CreateClaimsAsync(userById), AppConst.AcceptTokenExpiration);

                    // Update token
                    storedToken.Jti = acceptToken.Id;
                    await _userTokenRepository.UpdateAsync(storedToken);

                    var refreshTokenResult = new RefreshTokenResultDto()
                    {
                        AccessToken = new JwtSecurityTokenHandler().WriteToken(acceptToken),
                        RefreshToken = input.RefreshToken,
                        ExpireDate = Convert.ToInt64(acceptToken.ValidTo.ToString("yyyyMMddHHmmss")),
                    };

                    unitOfWork.Complete();
                    result.Success(refreshTokenResult);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return result;
        }

        public Task<ResultDto> ChangeWorkingBranch()
        {
            throw new NotImplementedException();
        }

        private async Task<JwtSecurityToken> CreateTokenAsync(IList<Claim> claims, TimeSpan? expriraton = null)
        {
            var now = DateTime.Now;
            var x = now.Add(expriraton.Value);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                issuer: _config["Tokens:Issuer"],
                audience: _config["Tokens:Issuer"],
                claims: claims,
                notBefore: now,
                expires: expriraton == null ? (DateTime?)null : now.Add(expriraton.Value),
                signingCredentials: creds);

            return await Task.FromResult(token);
        }

        private async Task<IList<Claim>> CreateClaimsAsync(User user, TokenTypes tokenType = TokenTypes.AcceptToken)
        {
            var roleIds = (await _userRoleMappingRepository.GetAllListAsync(x => x.UserId == user.Id)).Select(s => s.RoleId); // Context.UserRoleMapping.Where(w => w.UserId == user.Id).Select(s => s.RoleId).ToList();
            var roles = await _roleRepository.GetAllListAsync(x => roleIds.Contains(x.Id)); // Context.Role.Where(w => roleIds.Contains(w.Id)).ToList();

            var claims = new List<Claim>()
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FullName),
                new Claim(ClaimTypes.Role, string.Join(";", roles)),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("TokenType", ((int)tokenType).ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            return await Task.FromResult(claims);
        }

        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();

            return dateTimeInterval;
        }
    }
}
