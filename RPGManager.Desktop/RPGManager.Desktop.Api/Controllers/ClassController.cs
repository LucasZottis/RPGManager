using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/class" )]
public class ClassController : CrudController<Class, ClassRegisterDto, ClassQueryDto>
{
    public ClassController( IClassService service ) : base( service )
    {
    }
}