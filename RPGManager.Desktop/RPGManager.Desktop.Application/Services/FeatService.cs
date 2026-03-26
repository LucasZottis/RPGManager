using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Domain.Models.Feats;

namespace RPGManager.Desktop.Application.Services;

public class FeatService : CrudServiceBase<Feat, FeatRegisterDto, FeatQueryDto>, IFeatService
{
    public FeatService( IFeatRepository repository, IFeatMapper mapper ) : base( repository, mapper )
    {
    }
}
