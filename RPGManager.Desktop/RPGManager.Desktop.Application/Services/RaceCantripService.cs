namespace RPGManager.Desktop.Application.Services;

public class RaceCantripService : CrudServiceBase<RaceCantrip, RaceCantripRegisterDto, RaceCantripQueryDto>, IRaceCantripService
{
    public RaceCantripService( IRaceCantripRepository repository, IRaceCantripMapper mapper ) : base( repository, mapper )
    {
    }
}
