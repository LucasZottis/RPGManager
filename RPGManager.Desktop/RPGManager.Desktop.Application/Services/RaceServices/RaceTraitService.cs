using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
using RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

namespace RPGManager.Desktop.Application.Services.RaceServices;

public class RaceTraitService : CrudServiceBase<RaceTrait, RaceTraitRegisterDto, RaceTraitQueryDto>, IRaceTraitService
{
    public RaceTraitService( IRaceTraitRepository repository, IRaceTraitMapper mapper ) : base( repository, mapper )
    {
    }
}
