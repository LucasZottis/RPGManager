using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RPGManager.Desktop.Api.Controllers.Base
{
    [Authorize]
    [ApiController]
    public class AuthenticatedControllerBase : ControllerBase
    {
    }
}