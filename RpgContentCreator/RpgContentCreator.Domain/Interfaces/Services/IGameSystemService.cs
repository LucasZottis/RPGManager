using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.Domain.Interfaces.Services;

public interface IGameSystemService
{
    Task<GameSystemModel> Create( GameSystemModel gameSystem );
}