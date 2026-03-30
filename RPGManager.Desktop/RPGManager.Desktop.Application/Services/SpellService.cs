using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Spells;

namespace RPGManager.Desktop.Application.Services;

public class SpellService : CrudServiceBase<Spell, SpellRegisterDto, SpellQueryDto>, ISpellService
{
    public SpellService( ISpellRepository repository, ISpellMapper mapper ) : base( repository, mapper )
    {
    }
}
