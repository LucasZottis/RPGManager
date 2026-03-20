using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Application.DTOs.Races;
using RPGManager.Desktop.Application.Services.Interfaces;
using RPGManager.Desktop.Domain.Entities.RaceEntities;

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