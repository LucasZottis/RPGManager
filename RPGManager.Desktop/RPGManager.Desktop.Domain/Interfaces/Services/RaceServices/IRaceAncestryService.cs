using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

public interface IRaceAncestryService : ICrudServiceBase<RaceAncestry, RaceAncestryRegisterDto, RaceAncestryQueryDto>
{
}
