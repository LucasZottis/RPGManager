using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

namespace RPGManager.Desktop.Application.Services.RaceServices;

public class RaceAncestryService : CrudServiceBase<RaceAncestry, RaceAncestryRegisterDto, RaceAncestryQueryDto>, IRaceAncestryService
{
    public RaceAncestryService( IRaceAncestryRepository repository, IRaceAncestryMapper mapper ) : base( repository, mapper )
    {
    }
}
