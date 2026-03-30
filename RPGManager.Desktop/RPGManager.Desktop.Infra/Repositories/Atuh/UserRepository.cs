using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces.Repositories.AuthRepositories;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.Atuh;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository( Context context ) : base( context )
    {
    }

    public async Task<User?> GetByEmail( string email )
    {
        var user = await GetEntity( u => u.Email == email );
        return user;
    }
}