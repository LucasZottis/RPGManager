using RPGManager.Desktop.Domain.DTOs.Levels;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ILevelService : ICrudServiceBase<Level, LevelRegisterDto, LevelQueryDto>
{
}
