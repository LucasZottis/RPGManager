using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

namespace RPGManager.Desktop.Application.Services;

public class RaceTraitSpellLevelService : CrudServiceBase<RaceTraitSpellLevel, RaceTraitSpellLevelRegisterDto, RaceTraitSpellLevelQueryDto>, IRaceTraitSpellLevelService
{
    public RaceTraitSpellLevelService( IRaceTraitSpellLevelRepository repository, IRaceTraitSpellLevelMapper mapper ) : base( repository, mapper )
    {
    }
}
