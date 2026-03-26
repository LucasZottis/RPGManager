using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;

namespace RPGManager.Desktop.Application.Services;

public class RaceAncestrySpellService : CrudServiceBase<RaceAncestrySpell, RaceAncestrySpellRegisterDto, RaceAncestrySpellQueryDto>, IRaceAncestrySpellService
{
    public RaceAncestrySpellService( IRaceAncestrySpellRepository repository, IRaceAncestrySpellMapper mapper ) : base( repository, mapper )
    {
    }
}
