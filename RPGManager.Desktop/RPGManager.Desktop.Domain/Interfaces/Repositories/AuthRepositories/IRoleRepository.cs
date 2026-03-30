using RPGManager.Desktop.Domain.Entities.AuthEntities;

namespace RPGManager.Desktop.Domain.Interfaces.Repositories.AuthRepositories;

public interface IRoleRepository : IRepositoryBase<Role>
{
    Task<IEnumerable<Role>> RecoverRolesByUserId( Guid userId );
    Task<Role?> RecoverRoleByName( string roleName );
}