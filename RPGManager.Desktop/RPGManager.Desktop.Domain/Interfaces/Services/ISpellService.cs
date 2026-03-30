using RPGManager.Desktop.Domain.DTOs.Spells;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ISpellService : ICrudServiceBase<Spell, SpellRegisterDto, SpellQueryDto>
{
}
