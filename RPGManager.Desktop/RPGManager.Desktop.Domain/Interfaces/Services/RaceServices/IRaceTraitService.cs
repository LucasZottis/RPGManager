using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

public interface IRaceTraitService : ICrudServiceBase<RaceTrait, RaceTraitRegisterDto, RaceTraitQueryDto>
{
}
