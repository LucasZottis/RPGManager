using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

namespace RPGManager.Desktop.Application.Services;

public class RaceTraitSpellService : CrudServiceBase<RaceTraitSpell, RaceTraitSpellRegisterDto, RaceTraitSpellQueryDto>, IRaceTraitSpellService
{
    public RaceTraitSpellService( IRaceTraitSpellRepository repository, IRaceTraitSpellMapper mapper ) : base( repository, mapper )
    {
    }
}
