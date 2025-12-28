using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IGameSystemService : IServiceBase<GameSystem, GameSystemModel>
{
    //Task<GameSystemModel> Create( GameSystemModel gameSystem );
}