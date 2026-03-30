using DevToolz.Library.Extensions;
using Microsoft.Extensions.Options;
using RPGManager.Desktop.Application.Mappers.Base;
using RPGManager.Desktop.Application.Options;
using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Auth;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces.Mappers.Auth;
using RPGManager.Desktop.Domain.Interfaces.Services.Auth;
using RPGManager.Desktop.Domain.Interfaces.UnitOfWork;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace RPGManager.Desktop.Application.Services.Auth;

public class AuthenticationService : ServiceBase, IAuthenticationService
{
    private readonly IAuthorizationUnitOfWork _authorizationUnitOfWork;
    private readonly ITokenService _tokenService;
    private readonly IOptions<Encryption> _options;

    public AuthenticationService( IAuthorizationUnitOfWork authorizationUnitOfWork, ITokenService tokenService, IOptions<Encryption> options ) : base( new Mapper() )
    {
        _authorizationUnitOfWork = authorizationUnitOfWork;
        _tokenService = tokenService;
        _options = options;
    }

    private async Task<IEnumerable<Claim>> GetClaims( AuthenticatedUserDto authenticatedUser )
    {
        var claims = new List<Claim>
        {
            new Claim( ClaimTypes.NameIdentifier, authenticatedUser.Id.ToString() ),
            new Claim( ClaimTypes.Email, authenticatedUser.Email ),
            new Claim( ClaimTypes.Name, authenticatedUser.Name )
        };

        var userRoles = await _authorizationUnitOfWork.RoleRepository.RecoverRolesByUserId( authenticatedUser.Id );
        claims.AddRange( userRoles.Select( r => new Claim( ClaimTypes.Role, r.Name ) ) );

        return claims;
    }

    public async Task<AuthenticatedUserDto> ValidateLogin( AuthenticateUserDto authenticateUser )
    {
        var user = await _authorizationUnitOfWork.UserRepository.GetByEmail( authenticateUser.Email );

        if ( user.IsNull() )
            throw new Exception( "E-mail ou senha inválidos." );

        if ( !BCrypt.Net.BCrypt.Verify( authenticateUser.Password, user.PasswordHash ) )
            throw new Exception( "E-mail ou senha inválidos." );

        var authenticatedUser = Mapper.ToModel<User, AuthenticatedUserDto>( user );
        var claims = await GetClaims( authenticatedUser );
        var token = await _tokenService.GenerateAccessToken( claims );
        var refreshToken = await _tokenService.GenerateRefreshToken();

        authenticatedUser.AccessToken = new JwtSecurityTokenHandler().WriteToken( token );
        authenticatedUser.RefreshToken = refreshToken;

        return authenticatedUser;
    }

    public async Task<AuthenticatedUserDto> RefreshAuthentication( AuthenticatedUserDto authenticatedUser )
    {
        if ( authenticatedUser.AccessToken.IsEmpty() )
            throw new Exception( "Token inválido." );

        var principal = await _tokenService.GetPrincipalFromExpiredToken( authenticatedUser.AccessToken );

        if ( principal.IsNull() )
            throw new Exception( "Token inválido." );

        var userName = principal.Identity!.Name;
        var user = await _authorizationUnitOfWork.UserRepository.GetByEmail( authenticatedUser.Email );
        var newAccessToken = await _tokenService.GenerateAccessToken( principal.Claims );
        var newRefreshToken = await _tokenService.GenerateRefreshToken();

        //await _userService.UpdateTokenSettings( user, newRefreshToken, 0 );

        return new AuthenticatedUserDto
        {
            Id = authenticatedUser.Id,
            Name = authenticatedUser.Name,
            Email = authenticatedUser.Email,
            AccessToken = new JwtSecurityTokenHandler().WriteToken( newAccessToken ),
            RefreshToken = newRefreshToken,
        };
    }
}