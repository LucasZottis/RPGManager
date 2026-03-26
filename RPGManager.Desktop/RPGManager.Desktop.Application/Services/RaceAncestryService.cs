using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;

namespace RPGManager.Desktop.Application.Services;

public class RaceAncestryService : CrudServiceBase<RaceAncestry, RaceAncestryRegisterDto, RaceAncestryQueryDto>, IRaceAncestryService
{
    public RaceAncestryService( IRaceAncestryRepository repository, IRaceAncestryMapper mapper ) : base( repository, mapper )
    {
    }
}
