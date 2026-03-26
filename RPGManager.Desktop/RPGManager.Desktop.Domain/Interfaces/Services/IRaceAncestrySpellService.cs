using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Domain.Models.Races;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IRaceAncestrySpellService : ICrudServiceBase<RaceAncestrySpell, RaceAncestrySpellRegisterDto, RaceAncestrySpellQueryDto>
{
}
