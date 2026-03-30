using RPGManager.Desktop.Domain.DTOs.Auth.User;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.Auth;

public interface IUserService : IServiceBase
{
    Task<Guid> CreateUser( UserRegisterDto model );
}