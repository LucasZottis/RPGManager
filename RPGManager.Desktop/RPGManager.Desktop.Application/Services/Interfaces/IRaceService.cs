using RPGManager.Desktop.Application.DTOs.Races;

namespace RPGManager.Desktop.Application.Services.Interfaces;

public interface IRaceService : ICrudServiceBase<Race, RaceRegisterDto, RaceQueryDto>
{
}