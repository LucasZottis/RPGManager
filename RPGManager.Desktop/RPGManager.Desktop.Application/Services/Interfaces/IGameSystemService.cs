using RPGManager.Desktop.Application.DTOs.GameSystems;
using RPGManager.Desktop.Domain.Entities;

namespace RPGManager.Desktop.Application.Services.Interfaces;

public interface IGameSystemService : ICrudServiceBase<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>
{
}