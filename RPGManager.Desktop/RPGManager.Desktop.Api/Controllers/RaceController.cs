using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Api.Controllers.Base;
using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

namespace RPGManager.Desktop.Api.Controllers
{
    [Route( "api/race" )]
    public class RaceController : CrudController<Race, RaceRegisterDto, RaceQueryDto>
    {
        public RaceController( IRaceService service ) : base( service )
        {
        }
    }
}