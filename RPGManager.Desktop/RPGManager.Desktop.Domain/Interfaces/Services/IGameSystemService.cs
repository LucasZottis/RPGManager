using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Domain.Models.GameSystems;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IGameSystemService : ICrudServiceBase<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>
{
}