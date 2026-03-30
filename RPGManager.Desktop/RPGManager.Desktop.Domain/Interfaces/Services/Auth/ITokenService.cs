using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace RPGManager.Desktop.Domain.Interfaces.Services.Auth;

public interface ITokenService : IServiceBase
{
    Task<JwtSecurityToken> GenerateAccessToken( IEnumerable<Claim> claims );
    Task<string> GenerateRefreshToken();
    Task<ClaimsPrincipal> GetPrincipalFromExpiredToken( string token );
}