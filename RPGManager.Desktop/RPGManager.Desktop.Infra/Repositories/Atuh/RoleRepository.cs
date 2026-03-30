using Microsoft.EntityFrameworkCore;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces.Repositories.AuthRepositories;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.Atuh;

public class RoleRepository : RepositoryBase<Role>, IRoleRepository
{
    public RoleRepository( Context context ) : base( context )
    {
    }

    public async Task<Role?> RecoverRoleByName( string roleName )
    {
        return await Context.Set<Role>().FirstOrDefaultAsync( r => r.Name == roleName );
    }

    public async Task<IEnumerable<Role>> RecoverRolesByUserId( Guid userId )
    {
        var query = from role in Context.Set<Role>()
                    join userRole in Context.Set<UserRole>() on role.Id equals userRole.RoleId
                    where userRole.UserId == userId
                    select role;

        var result = await query.ToListAsync();

        return result;
    }
}