using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.Interfaces.Services.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace RPGManager.Desktop.Application.Services.Auth;

public class TokenService : ServiceBase, ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService( IConfiguration configuration )
    {
        _configuration = configuration;
    }

    public async Task<JwtSecurityToken> GenerateAccessToken( IEnumerable<Claim> claims )
    {
        var secretKey = _configuration.GetValue<string>( "JWT:SecretKey" )
            ?? throw new InvalidOperationException( "Chave secreta não encontrada" );

        //var claims = await GetClaims( authenticatedUser );
        var expirationTime = _configuration.GetValue<double>( "JWT:AccessTokenExpiration" );
        var audience = _configuration.GetValue<string>( "JWT:ValidAudience" );
        var issuer = _configuration.GetValue<string>( "JWT:ValidIssuer" );
        var privateKey = Encoding.UTF8.GetBytes( secretKey );
        var signingCredentials = new SigningCredentials( new SymmetricSecurityKey( privateKey ), SecurityAlgorithms.HmacSha256Signature );
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateJwtSecurityToken( new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity( claims ),
            Expires = DateTime.UtcNow.AddMinutes( expirationTime ),
            Audience = audience,
            Issuer = issuer,
            SigningCredentials = signingCredentials,
        } );

        return token;
    }

    public async Task<string> GenerateRefreshToken()
    {
        var secureRandomBytes = new byte[ 128 ];
        using var randomNumberGenerator = RandomNumberGenerator.Create();

        randomNumberGenerator.GetBytes( secureRandomBytes );

        var refreshToken = Convert.ToBase64String( secureRandomBytes );

        return refreshToken;
    }

    public async Task<ClaimsPrincipal> GetPrincipalFromExpiredToken( string token )
    {
        var secretKey = _configuration.GetValue<string>( "JWT:SecretKey" )
            ?? throw new InvalidOperationException( "Chave secreta não encontrada" );

        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes( secretKey ) ),
            ValidateLifetime = false,
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var principal = tokenHandler.ValidateToken( token, tokenValidationParameters, out var securityToken );

        if ( securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals( SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase ) )
            throw new SecurityTokenException( "Token é inválido" );

        return principal;
    }
}