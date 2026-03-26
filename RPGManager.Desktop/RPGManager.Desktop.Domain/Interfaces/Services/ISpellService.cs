using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Spells;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ISpellService : ICrudServiceBase<Spell, SpellRegisterDto, SpellQueryDto>
{
}
