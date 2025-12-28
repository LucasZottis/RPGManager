using RPGManager.Desktop.Application.Interfaces;

namespace RPGManager.Desktop.Application.Services;

public class RaceService : ServiceBase<Race, RaceModel>, IRaceService
{
    public RaceService( IRaceRepository repository, IRaceMapper mapper ) : base( repository, mapper )
    {
    }
}