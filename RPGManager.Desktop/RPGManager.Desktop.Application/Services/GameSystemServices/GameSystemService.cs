using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.GameSystems;
using RPGManager.Desktop.Domain.Entities.GameSystems;


namespace RPGManager.Desktop.Application.Services.GameSystemServices;

public class GameSystemService : CrudServiceBase<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>, IGameSystemService
{
    private readonly IGameSystemUnitOfWork _gameSystemUnitOfWork;

    public GameSystemService( IGameSystemUnitOfWork unitOfWork, IGameSystemMapper mapper ) : base( unitOfWork.GameSystemRepository, mapper )
    {
        _gameSystemUnitOfWork = unitOfWork;
    }

    public async Task<Guid> CreateVersion( Guid gameSystemId, GameSystemVersionRegisterDto gameSystemVersion )
    {
        var gameSystem = await _gameSystemUnitOfWork.GameSystemRepository.GetById( gameSystemId );
        var newVersion = Mapper.ToEntity<GameSystemVersion, GameSystemVersionRegisterDto>( gameSystemVersion );

        //if ( gameSystem.Versions == null )
        //    gameSystem.Versions = [];

        gameSystem.Versions.Add( newVersion );

        await _gameSystemUnitOfWork.GameSystemRepository.Update( gameSystem );
        await _gameSystemUnitOfWork.Commit();

        return newVersion.Id;
    }

    public async Task<GameSystemVersionQueryDto> GetVersionById( Guid gameSystemVersionId )
    {
        var versions = await _gameSystemUnitOfWork.GameSystemVersionRepository.GetById( gameSystemVersionId );
        return Mapper.ToModel<GameSystemVersion, GameSystemVersionQueryDto>( versions );
    }

    public async Task<IEnumerable<GameSystemVersionQueryDto>> GetVersions( Guid gameSystemId )
    {
        var versions = await _gameSystemUnitOfWork.GameSystemVersionRepository.GetByGameSystemId( gameSystemId );
        return Mapper.ToModel<IEnumerable<GameSystemVersion>, IEnumerable<GameSystemVersionQueryDto>>( versions );
    }
}