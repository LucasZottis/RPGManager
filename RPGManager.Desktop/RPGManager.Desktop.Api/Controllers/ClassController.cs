using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Api.Controllers.Base;
using RPGManager.Desktop.Domain.DTOs.Classes;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.ClassServices;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/class" )]
public class ClassController : CrudController<Class, ClassRegisterDto, ClassQueryDto>
{
    public ClassController( IClassService service ) : base( service )
    {
    }
}