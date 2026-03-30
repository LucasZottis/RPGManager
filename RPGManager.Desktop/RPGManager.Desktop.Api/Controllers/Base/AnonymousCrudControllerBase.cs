using Microsoft.AspNetCore.Authorization;
using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Api.Controllers.Base;

[AllowAnonymous]
public class AnonymousCrudControllerBase<TEntity, TRegister, TQuery> : CrudController<TEntity, TRegister, TQuery>
    where TEntity : EntityBase
    where TRegister : class
    where TQuery : class
{
    public AnonymousCrudControllerBase( ICrudServiceBase<TEntity, TRegister, TQuery> service ) : base( service )
    {
    }
}
