using DevToolz.Library.Extensions;
using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.Constants;
using RPGManager.Desktop.Domain.DTOs.Auth;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces.Mappers.Auth;
using RPGManager.Desktop.Domain.Interfaces.Services.Auth;
using RPGManager.Desktop.Domain.Interfaces.UnitOfWork;

namespace RPGManager.Desktop.Application.Services.Auth;

public class AuthorizationService : ServiceBase, IAuthorizationService
{
    private readonly IAuthorizationUnitOfWork _authorizationUnitOfWork;

    public AuthorizationService( IRoleMapper mapper, IAuthorizationUnitOfWork authorizationUnitOfWork ) : base( mapper )
    {
        _authorizationUnitOfWork = authorizationUnitOfWork;
    }

    public async Task<IEnumerable<RoleQueryDto>> GetUserCredentials( Guid userId )
    {
        var roles = await _authorizationUnitOfWork.RoleRepository.RecoverRolesByUserId( userId );
        var list = Mapper.ToModel<IEnumerable<Role>, IEnumerable<RoleQueryDto>>( roles );

        return list;
    }

    public async Task CreateDefaultRoles()
    {
        var adminRole = await _authorizationUnitOfWork.RoleRepository.RecoverRoleByName( Roles.Admin );

        if ( adminRole.IsNull() )
        {
            await _authorizationUnitOfWork.RoleRepository.Add( new Role
            {
                Name = Roles.Admin,
                Description = "Role with all permissions."
            } );
        }

        var userRole = await _authorizationUnitOfWork.RoleRepository.RecoverRoleByName( Roles.Admin );

        if ( userRole.IsNull() )
        {
            await _authorizationUnitOfWork.RoleRepository.Add( new Role
            {
                Name = Roles.User,
                Description = "Role with limited permissions."
            } );
        }

        await _authorizationUnitOfWork.Commit();
    }
}