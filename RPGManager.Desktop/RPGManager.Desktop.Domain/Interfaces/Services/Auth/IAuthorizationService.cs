using RPGManager.Desktop.Domain.DTOs.Auth;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.Auth;

public interface IAuthorizationService : IServiceBase
{
    Task<IEnumerable<RoleQueryDto>> GetUserCredentials( Guid userId );
    Task CreateDefaultRoles();
}