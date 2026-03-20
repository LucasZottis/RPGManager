using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Application.DTOs.Classes;
using RPGManager.Desktop.Application.Services.Interfaces;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/class" )]
public class ClassController : CrudController<Class, ClassRegisterDto, ClassQueryDto>
{
    public ClassController( IClassService service ) : base( service )
    {
    }
}