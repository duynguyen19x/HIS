using HIS.Dtos.Systems.Login;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Enums;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Authorization.Dto;
using HIS.Utilities.Commons;

namespace HIS.ApplicationService.Systems.Login
{
    public class LoginService : ILoginService
    {
        private readonly HISDbContext Context;
        private readonly IConfiguration _config;

        public LoginService(HISDbContext dbContext,
            IConfiguration config)
        {
            Context = dbContext;
            _config = config;
        }

        public async Task<ResultDto<TokenResultDto>> Authenticate(LoginDto request)
        {
            var ResultDto = new ResultDto<TokenResultDto>();

            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var user = Context.User.Where(w => w.Username == request.Username && w.Password.ToUpper() == request.Password.ToUpper()).FirstOrDefault();
                    if (user == null)
                    {
                        ResultDto.IsSucceeded = false;
                        ResultDto.Message = "Tài khoản hoặc mật khẩu không đúng!";

                        return ResultDto;
                    }

                    var acceptToken = await CreateTokenAsync(await CreateClaimsAsync(user), AppConst.AcceptTokenExpiration);
                    var refreshToken = await CreateTokenAsync(await CreateClaimsAsync(user, TokenTypes.RefreshToken), AppConst.RefreshTokenExpiration);

                    var token = new TokenResultDto()
                    {
                        AcceptToken = new JwtSecurityTokenHandler().WriteToken(acceptToken),
                        RefreshToken = new JwtSecurityTokenHandler().WriteToken(refreshToken),
                    };

                    ResultDto.IsSucceeded = true;
                    ResultDto.Result = token;

                    // Save token
                    var sToken = new UserToken()
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

                    await Context.Tokens.AddAsync(sToken);
                    Context.SaveChanges();

                    // Lưu thông tin đăng nhập
                    SessionExtensions.Login = new LoginSecsion
                    {
                        Id = user.Id,
                        UserName = user.Username
                    };

                    transaction.Commit();
                }
                catch (Exception)
                {
                    ResultDto.IsSucceeded = false;
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(ResultDto);
        }

        public async Task<ResultDto<bool>> Register(RegisterDto request)
        {
            var ResultDto = new ResultDto<bool>();

            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var user = Context.User.FirstOrDefault(f => f.Username == request.UserName);
                    if (user != null)
                    {
                        ResultDto.Result = false;
                        ResultDto.IsSucceeded = false;
                        ResultDto.Message = "Tài khoản đã tồn tại";

                        return await Task.FromResult(ResultDto);
                    }

                    user = Context.User.FirstOrDefault(f => f.Email == request.UserName);
                    if (user != null)
                    {
                        ResultDto.Result = false;
                        ResultDto.IsSucceeded = false;
                        ResultDto.Message = "Emai đã tồn tại";

                        return await Task.FromResult(ResultDto);
                    }

                    var userSave = new User()
                    {
                        Id = Guid.NewGuid(),
                        Username = request.UserName,
                        Password = request.Password,
                        Mobile = request.PhoneNumber,
                        Email = request.Email,
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        //Address = request.Address,
                        //Dob = request.Dob,
                        //UseType = request.UseType,
                        //Status = request.Status,
                        //GenderId = request.GenderId,
                        //ProvinceId = request.ProvinceId,
                        //DistrictId = request.District,
                        //WardId = request.WardsId,
                    };
                    var result = Context.User.Add(userSave);
                    if (result != null)
                    {
                        ResultDto.Message = "Đăng ký thằng công!";
                        ResultDto.Result = true;
                        ResultDto.IsSucceeded = true;

                        return await Task.FromResult(ResultDto);
                    }
                }
                catch (Exception ex)
                {
                    ResultDto.Message = ex.Message;
                    ResultDto.Result = false;
                    ResultDto.IsSucceeded = false;
                }
            }

            return await Task.FromResult(ResultDto);
        }

        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();

            return dateTimeInterval;
        }

        private async Task<IList<Claim>> CreateClaimsAsync(User user, TokenTypes tokenType = TokenTypes.AcceptToken)
        {
            var roleIds = Context.UserRoleMapping.Where(w => w.UserId == user.Id).Select(s => s.RoleId).ToList();
            var roles = Context.Role.Where(w => roleIds.Contains(w.Id)).ToList();

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
            var ResultDto = new ResultDto<TokenResultDto>();

            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    if (string.IsNullOrEmpty(token.RefreshToken))
                    {
                        ResultDto.IsSucceeded = false;
                        ResultDto.Message = "Refresh token is not valid!";

                        return ResultDto;
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
                            ResultDto.Message = "Invalid token";
                            ResultDto.IsSucceeded = false;

                            return ResultDto;
                        }
                    }

                    // Check acceptToken đã hoạt động chưa
                    var utcExpireDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(f => f.Type == JwtRegisteredClaimNames.Exp).Value);
                    if (ConvertUnixTimeToDateTime(utcExpireDate) >= DateTime.UtcNow)
                    {
                        ResultDto.Message = "The access token has expired!";
                        ResultDto.IsSucceeded = false;

                        return ResultDto;
                    }

                    // Kiểm tra refreshToken có trong database ko?
                    var storedToken = Context.Tokens.Where(w => w.TokenValue == token.RefreshToken).FirstOrDefault(); // RefreshToken = RefreshToken trong database
                    if (storedToken == null)
                    {
                        ResultDto.Message = "Refresh token does not exist";
                        ResultDto.IsSucceeded = false;

                        return ResultDto;
                    }
                    else
                    {
                        // Kiểm tra hạn sử dụng
                        if (storedToken.ExpiredAt < DateTime.Now)
                        {
                            ResultDto.Message = "Refresh token token has expired!";
                            ResultDto.IsSucceeded = false;

                            return ResultDto;
                        }

                        // Kiểm tra refreshToken đã sử dụng chưa
                        if (storedToken.IsUsed)
                        {
                            ResultDto.Message = "Refresh token has been used";
                            ResultDto.IsSucceeded = false;

                            return ResultDto;
                        }

                        // Kiểm tra refreshToken đã thu hổi chưa
                        if (storedToken.IsRevoked)
                        {
                            ResultDto.Message = "Refresh token has been revoked";
                            ResultDto.IsSucceeded = false;

                            return ResultDto;
                        }
                    }

                    // Kiểm tra Id có trong RefreshToken 
                    var jti = tokenInVerification.Claims.FirstOrDefault(f => f.Type == JwtRegisteredClaimNames.Jti).Value;
                    if (storedToken.Jti != jti)
                    {
                        ResultDto.Message = "Token doesn't match";
                        ResultDto.IsSucceeded = false;

                        return ResultDto;
                    }

                    // Tạo token mới
                    var userById = Context.User.FirstOrDefault(f => f.Id == storedToken.UserId.GetValueOrDefault());
                    var acceptToken = await CreateTokenAsync(await CreateClaimsAsync(userById), AppConst.AcceptTokenExpiration);

                    // Update token
                    storedToken.Jti = acceptToken.Id;
                    Context.Update(storedToken);

                    ResultDto.Result = new TokenResultDto()
                    {
                        AcceptToken = new JwtSecurityTokenHandler().WriteToken(acceptToken),
                        RefreshToken = token.RefreshToken
                    };

                    Context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    ResultDto.Message = ex.Message;
                    ResultDto.IsSucceeded = false;
                    transaction.Dispose();
                }
            }

            return ResultDto;
        }
    }
}
