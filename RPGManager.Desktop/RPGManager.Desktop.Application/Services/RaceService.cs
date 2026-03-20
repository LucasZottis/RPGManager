using RPGManager.Desktop.Application.DTOs.Races;
using RPGManager.Desktop.Application.Mappers.Interfaces;
using RPGManager.Desktop.Application.Services.Interfaces;

namespace RPGManager.Desktop.Application.Services;

public class RaceService : CrudServiceBase<Race, RaceRegisterDto, RaceQueryDto>, IRaceService
{
    public RaceService( IRaceRepository repository, IRaceMapper mapper ) : base( repository, mapper )
    {
    }
}