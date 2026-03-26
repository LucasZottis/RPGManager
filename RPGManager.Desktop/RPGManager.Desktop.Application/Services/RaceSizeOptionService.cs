namespace RPGManager.Desktop.Application.Services;

public class RaceSizeOptionService : CrudServiceBase<RaceSizeOption, RaceSizeOptionRegisterDto, RaceSizeOptionQueryDto>, IRaceSizeOptionService
{
    public RaceSizeOptionService( IRaceSizeOptionRepository repository, IRaceSizeOptionMapper mapper ) : base( repository, mapper )
    {
    }
}
