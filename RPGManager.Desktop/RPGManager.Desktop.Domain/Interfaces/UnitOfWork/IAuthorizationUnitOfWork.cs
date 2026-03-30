using RPGManager.Desktop.Domain.Interfaces.Repositories.AuthRepositories;

namespace RPGManager.Desktop.Domain.Interfaces.UnitOfWork;

public interface IAuthorizationUnitOfWork : IUnitOfWorkBase
{
    IUserRepository UserRepository { get; }
    IRoleRepository RoleRepository { get; }
}