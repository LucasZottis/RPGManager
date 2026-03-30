using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Api.Controllers.Base;

[Authorize]
public class AuthenticatedCrudControllerBase<TEntity, TRegister, TQuery> : CrudController<TEntity, TRegister, TQuery>
    where TEntity : EntityBase
    where TRegister : class
    where TQuery : class
{
    public AuthenticatedCrudControllerBase( ICrudServiceBase<TEntity, TRegister, TQuery> service ) : base( service )
    {
    }
}
