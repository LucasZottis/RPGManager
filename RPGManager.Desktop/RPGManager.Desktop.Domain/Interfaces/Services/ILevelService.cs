using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Levels;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ILevelService : ICrudServiceBase<Level, LevelRegisterDto, LevelQueryDto>
{
}
