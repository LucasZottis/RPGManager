using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

namespace RPGManager.Desktop.Application.Services;

public class RaceTraitService : CrudServiceBase<RaceTrait, RaceTraitRegisterDto, RaceTraitQueryDto>, IRaceTraitService
{
    public RaceTraitService( IRaceTraitRepository repository, IRaceTraitMapper mapper ) : base( repository, mapper )
    {
    }
}
