using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/background" )]
public class BackgroundController : CrudController<Background, BackgroundRegisterDto, BackgroundQueryDto>
{
    public BackgroundController( IBackgroundService service ) : base( service )
    {
    }
}