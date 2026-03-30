using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.Constants;
using RPGManager.Desktop.Domain.DTOs.Auth.User;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces.Mappers.Auth;
using RPGManager.Desktop.Domain.Interfaces.Services.Auth;
using RPGManager.Desktop.Domain.Interfaces.UnitOfWork;

namespace RPGManager.Desktop.Application.Services.Auth;

public class UserService : ServiceBase, IUserService
{
    private readonly IAuthorizationUnitOfWork _authorizationUnitOfWork;

    public UserService( IAuthorizationUnitOfWork authorizationUnitOfWork, IUserMapper mapper ) : base( mapper )
    {
        _authorizationUnitOfWork = authorizationUnitOfWork;
    }

    private async Task<Guid> Create( Guid roleId, UserRegisterDto model )
    {
        var user = Mapper.ToEntity<User, UserRegisterDto>( model );

        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword( model.Password );
        user.CreatedAt = DateTime.UtcNow;
        user.Roles = new List<UserRole>
        {
            new UserRole
            {
                RoleId = roleId,
            }
        };

        await _authorizationUnitOfWork.UserRepository.Add( user );
        await _authorizationUnitOfWork.Commit();

        return user.Id;
    }

    public async Task<Guid> CreateUser( UserRegisterDto model )
    {
        var userRole = await _authorizationUnitOfWork.RoleRepository.RecoverRoleByName( Roles.User );
        return await Create( userRole.Id, model );
    }

    //public async Task CreateAdmin()
    //{
    //    var userRole = await _authorizationUnitOfWork.RoleRepository.RecoverRoleByName( Roles.Admin );
    //    var admin = new UserRegisterDto
    //    {
    //        Name = "Lucas Zottis",
    //        Email = "zottis.lucas@hotmail.com",
    //        Password = "Foxtrot@153"
    //    };

    //    await Create( userRole.Id, admin );
    //}
}