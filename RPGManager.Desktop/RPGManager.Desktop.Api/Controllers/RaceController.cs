using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Models.Races;

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