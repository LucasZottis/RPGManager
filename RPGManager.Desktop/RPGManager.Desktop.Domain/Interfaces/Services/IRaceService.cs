using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Models.Races;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IRaceService : ICrudServiceBase<Race, RaceRegisterDto, RaceQueryDto>
{
}