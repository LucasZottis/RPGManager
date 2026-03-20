namespace RPGManager.Desktop.Application.Services;

public class RaceService : CrudServiceBase<Race, RaceRegisterDto, RaceQueryDto>, IRaceService
{
    public RaceService( IRaceRepository repository, IRaceMapper mapper ) : base( repository, mapper )
    {
    }
}