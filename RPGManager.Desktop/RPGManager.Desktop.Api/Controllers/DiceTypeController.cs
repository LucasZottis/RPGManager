using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Domain.Models.Dices;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/dice-type" )]
public class DiceTypeController : CrudController<DiceType, DiceTypeRegisterDto, DiceTypeQueryDto>
{
    public DiceTypeController( IDiceTypeService service ) : base( service )
    {
    }
}