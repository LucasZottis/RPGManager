using RPGManager.Desktop.Domain.DTOs.GameSystems;
using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IGameSystemService : ICrudServiceBase<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>
{
    Task<Guid> CreateVersion( Guid gameSystemId, GameSystemVersionRegisterDto gameSystemVersion );
    Task<IEnumerable<GameSystemVersionQueryDto>> GetVersions( Guid gameSystemId );
    Task<GameSystemVersionQueryDto> GetVersionById( Guid gameSystemVersionId );
}