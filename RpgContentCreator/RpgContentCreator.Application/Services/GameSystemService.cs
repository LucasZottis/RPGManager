namespace RpgContentCreator.Application.Services;

public class GameSystemService : IGameSystemService
{
    private readonly IGameSystemRepository _repository;

    public GameSystemService( IGameSystemRepository repository )
    {
        _repository = repository;
    }

    public async Task<GameSystemModel> Create( GameSystemModel model )
    {
        var entity = new GameSystem
        {
            Name = model.Name,
        };

        await _repository.Add( entity );
        await _repository.SaveChanges();

        model.Id = entity.Id;

        return model;
    }
}