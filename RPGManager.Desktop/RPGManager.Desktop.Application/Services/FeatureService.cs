using RPGManager.Desktop.Domain.Models.Features;

namespace RPGManager.Desktop.Application.Services;

public class FeatureService : CrudServiceBase<Feature, FeatureRegisterDto, FeatureQueryDto>, IFeatureService
{
    public FeatureService( IFeatureRepository repository, IFeatureMapper mapper ) : base( repository, mapper )
    {
    }
}
