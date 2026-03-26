using RPGManager.Desktop.Domain.Models.Spells;

namespace RPGManager.Desktop.Application.Services;

public class SpellService : CrudServiceBase<Spell, SpellRegisterDto, SpellQueryDto>, ISpellService
{
    public SpellService( ISpellRepository repository, ISpellMapper mapper ) : base( repository, mapper )
    {
    }
}
