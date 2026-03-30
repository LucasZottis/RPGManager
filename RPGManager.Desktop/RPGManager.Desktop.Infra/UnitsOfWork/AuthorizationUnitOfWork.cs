using RPGManager.Desktop.Domain.Interfaces.Repositories.AuthRepositories;
using RPGManager.Desktop.Domain.Interfaces.UnitOfWork;
using RPGManager.Desktop.Infra.Db.Contexts;
using RPGManager.Desktop.Infra.Repositories.Atuh;

namespace RPGManager.Desktop.Infra.UnitsOfWork;

public class AuthorizationUnitOfWork : UnitOfWorkBase, IAuthorizationUnitOfWork
{
    public IUserRepository UserRepository { get; private set; }

    public IRoleRepository RoleRepository { get; private set; }

    public AuthorizationUnitOfWork( Context context ) : base( context )
    {
        UserRepository ??= new UserRepository(context);
        RoleRepository ??= new RoleRepository(context);
    }
}