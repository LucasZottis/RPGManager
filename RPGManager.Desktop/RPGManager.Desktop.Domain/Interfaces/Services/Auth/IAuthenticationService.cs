using RPGManager.Desktop.Domain.DTOs.Auth;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.Auth;

public interface IAuthenticationService : IServiceBase
{
    Task<AuthenticatedUserDto> ValidateLogin( AuthenticateUserDto authenticateUser );
    Task<AuthenticatedUserDto> RefreshAuthentication( AuthenticatedUserDto authenticatedUser );
}