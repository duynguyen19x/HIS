using HIS.Dtos.Systems.Login;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HIS.Application.Core.Services.Dto;

namespace HIS.ApplicationService.Systems.Login
{
    public class LoginService : ILoginService
    {
        private readonly HISDbContext _dbContext;
        private readonly IConfiguration _config;

        public LoginService(HISDbContext dbContext,
            IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }

        public async Task<ResultDto<TokenResultDto>> Authenticate(LoginDto request)
        {
            var apiResult = new ResultDto<TokenResultDto>();

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var user = _dbContext.Users.Where(w => w.UserName == request.UserName && w.Password.ToUpper() == request.Password.ToUpper()).FirstOrDefault();
                    if (user == null)
                    {
                        apiResult.IsSucceeded = false;
                        apiResult.Message = "Tài khoản hoặc mật khẩu không đúng!";

                        return apiResult;
                    }

                    var acceptToken = await CreateTokenAsync(await CreateClaimsAsync(user), AppConst.AcceptTokenExpiration);
                    var refreshToken = await CreateTokenAsync(await CreateClaimsAsync(user, TokenTypes.RefreshToken), AppConst.RefreshTokenExpiration);

                    var token = new TokenResultDto()
                    {
                        AcceptToken = new JwtSecurityTokenHandler().WriteToken(acceptToken),
                        RefreshToken = new JwtSecurityTokenHandler().WriteToken(refreshToken),
                    };

                    apiResult.IsSucceeded = true;
                    apiResult.Item = token;

                    // Save token
                    var sToken = new SToken()
                    {
                        Id = Guid.NewGuid(),
                        UserId = user.Id,
                        TokenValue = token.RefreshToken,
                        Jti = acceptToken.Id,
                        IsUsed = false,
                        IsRevoked = false,
                        IssueAt = refreshToken.ValidFrom,
                        ExpiredAt = refreshToken.ValidTo
                    };

                    await _dbContext.Tokens.AddAsync(sToken);
                    _dbContext.SaveChanges();

                    // Lưu thông tin đăng nhập
                    SessionExtensions.Login = new LoginSecsion
                    {
                        Id = user.Id,
                        UserName = user.UserName
                    };

                    transaction.Commit();
                }
                catch (Exception)
                {
                    apiResult.IsSucceeded = false;
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(apiResult);
        }

        public async Task<ResultDto<bool>> Register(RegisterDto request)
        {
            var apiResult = new ResultDto<bool>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var user = _dbContext.Users.FirstOrDefault(f => f.UserName == request.UserName);
                    if (user != null)
                    {
                        apiResult.Item = false;
                        apiResult.IsSucceeded = false;
                        apiResult.Message = "Tài khoản đã tồn tại";

                        return await Task.FromResult(apiResult);
                    }

                    user = _dbContext.Users.FirstOrDefault(f => f.Email == request.UserName);
                    if (user != null)
                    {
                        apiResult.Item = false;
                        apiResult.IsSucceeded = false;
                        apiResult.Message = "Emai đã tồn tại";

                        return await Task.FromResult(apiResult);
                    }

                    var userSave = new EntityFrameworkCore.Entities.Systems.User()
                    {
                        Id = Guid.NewGuid(),
                        UserName = request.UserName,
                        Password = request.Password,
                        PhoneNumber = request.PhoneNumber,
                        Email = request.Email,
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        Address = request.Address,
                        Dob = request.Dob,
                        UseType = request.UseType,
                        Status = request.Status,
                        GenderId = request.GenderId,
                        ProvinceId = request.ProvinceId,
                        DistrictId = request.District,
                        WardId = request.WardsId,
                    };
                    var result = _dbContext.Users.Add(userSave);
                    if (result != null)
                    {
                        apiResult.Message = "Đăng ký thằng công!";
                        apiResult.Item = true;
                        apiResult.IsSucceeded = true;

                        return await Task.FromResult(apiResult);
                    }
                }
                catch (Exception ex)
                {
                    apiResult.Message = ex.Message;
                    apiResult.Item = false;
                    apiResult.IsSucceeded = false;
                }
            }

            return await Task.FromResult(apiResult);
        }

        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();

            return dateTimeInterval;
        }

        private async Task<IList<Claim>> CreateClaimsAsync(EntityFrameworkCore.Entities.Systems.User user, TokenTypes tokenType = TokenTypes.AcceptToken)
        {
            var roleIds = _dbContext.UserRoles.Where(w => w.UserId == user.Id).Select(s => s.RoleId).ToList();
            var roles = _dbContext.Roles.Where(w => roleIds.Contains(w.Id)).ToList();

            var claims = new List<Claim>()
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";", roles)),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim("TokenType", ((int)tokenType).ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            return await Task.FromResult(claims);
        }

        private async Task<JwtSecurityToken> CreateTokenAsync(IList<Claim> claims, TimeSpan? expriraton = null)
        {
            var now = DateTime.Now;
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

        public async Task<ResultDto<TokenResultDto>> RefreshToken(TokenResultDto token)
        {
            var apiResult = new ResultDto<TokenResultDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    if (string.IsNullOrEmpty(token.RefreshToken))
                    {
                        apiResult.IsSucceeded = false;
                        apiResult.Message = "Refresh token is not valid!";

                        return apiResult;
                    }

                    var key = Encoding.UTF8.GetBytes(_config["Tokens:Key"]);
                    string issuer = _config["Tokens:Issuer"];

                    // Check valid format
                    var tokenInVerification = new JwtSecurityTokenHandler().ValidateToken(token.AcceptToken, new TokenValidationParameters()
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
                            apiResult.Message = "Invalid token";
                            apiResult.IsSucceeded = false;

                            return apiResult;
                        }
                    }

                    // Check acceptToken đã hoạt động chưa
                    var utcExpireDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(f => f.Type == JwtRegisteredClaimNames.Exp).Value);
                    if (ConvertUnixTimeToDateTime(utcExpireDate) >= DateTime.UtcNow)
                    {
                        apiResult.Message = "The access token has expired!";
                        apiResult.IsSucceeded = false;

                        return apiResult;
                    }

                    // Kiểm tra refreshToken có trong database ko?
                    var storedToken = _dbContext.Tokens.Where(w => w.TokenValue == token.RefreshToken).FirstOrDefault(); // RefreshToken = RefreshToken trong database
                    if (storedToken == null)
                    {
                        apiResult.Message = "Refresh token does not exist";
                        apiResult.IsSucceeded = false;

                        return apiResult;
                    }
                    else
                    {
                        // Kiểm tra hạn sử dụng
                        if (storedToken.ExpiredAt < DateTime.Now)
                        {
                            apiResult.Message = "Refresh token token has expired!";
                            apiResult.IsSucceeded = false;

                            return apiResult;
                        }

                        // Kiểm tra refreshToken đã sử dụng chưa
                        if (storedToken.IsUsed)
                        {
                            apiResult.Message = "Refresh token has been used";
                            apiResult.IsSucceeded = false;

                            return apiResult;
                        }

                        // Kiểm tra refreshToken đã thu hổi chưa
                        if (storedToken.IsRevoked)
                        {
                            apiResult.Message = "Refresh token has been revoked";
                            apiResult.IsSucceeded = false;

                            return apiResult;
                        }
                    }

                    // Kiểm tra Id có trong RefreshToken 
                    var jti = tokenInVerification.Claims.FirstOrDefault(f => f.Type == JwtRegisteredClaimNames.Jti).Value;
                    if (storedToken.Jti != jti)
                    {
                        apiResult.Message = "Token doesn't match";
                        apiResult.IsSucceeded = false;

                        return apiResult;
                    }

                    // Tạo token mới
                    var userById = _dbContext.Users.FirstOrDefault(f => f.Id == storedToken.UserId.GetValueOrDefault());
                    var acceptToken = await CreateTokenAsync(await CreateClaimsAsync(userById), AppConst.AcceptTokenExpiration);

                    // Update token
                    storedToken.Jti = acceptToken.Id;
                    _dbContext.Update(storedToken);

                    apiResult.Item = new TokenResultDto()
                    {
                        AcceptToken = new JwtSecurityTokenHandler().WriteToken(acceptToken),
                        RefreshToken = token.RefreshToken
                    };

                    _dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    apiResult.Message = ex.Message;
                    apiResult.IsSucceeded = false;
                    transaction.Dispose();
                }
            }

            return apiResult;
        }
    }
}
