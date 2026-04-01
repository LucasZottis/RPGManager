using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces;

namespace RPGManager.Desktop.Infra.Seeds;

public class AuthSeed
{
    private readonly ICrypt _crypt;

    private Guid UserAdminId = Guid.NewGuid();
    private IDictionary<string, Guid> RolesId = new Dictionary<string, Guid> {
        { Roles.Admin, Guid.NewGuid() },
        { Roles.User, Guid.NewGuid() },
    };

    public AuthSeed( ICrypt crypt )
    {
        _crypt = crypt;
    }

    public User GetUserAdmin()
    {
        return new User
        {
            Id = UserAdminId,
            Name = "Lucas Zottis",
            Email = "a@a.com.br",
            PasswordHash = _crypt.Hash( "123" ),
        };
    }

    public IEnumerable<Role> GetRoles()
    {
        return [
            new Role
            {
                Id = RolesId[Roles.Admin],
                Name = Roles.Admin,
                Description = "Role with all permissions.",
            },
            new Role
            {
                Id = RolesId[Roles.User],
                Name = Roles.Admin,
                Description = "Role with limited permissions.",
            },
        ];
    }

    public IEnumerable<UserRole> GetUserRoles()
    {
        return [
            new UserRole
            {
                UserId = UserAdminId,
                RoleId = RolesId[Roles.Admin],
            },
        ];
    }
}