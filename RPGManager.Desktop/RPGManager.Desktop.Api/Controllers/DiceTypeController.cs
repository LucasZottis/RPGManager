using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Api.Controllers.Base;
using RPGManager.Desktop.Domain.DTOs.Dices;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/dice-type" )]
[Authorize( Policy = "GameSystemControl" )]
public class DiceTypeController : CrudController<DiceType, DiceTypeRegisterDto, DiceTypeQueryDto>
{
    public DiceTypeController( IDiceTypeService service ) : base( service )
    {
    }
}