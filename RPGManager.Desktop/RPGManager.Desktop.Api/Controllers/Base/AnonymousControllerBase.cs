using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RPGManager.Desktop.Api.Controllers.Base;

[AllowAnonymous]
[ApiController]
public class AnonymousControllerBase : ControllerBase
{
}