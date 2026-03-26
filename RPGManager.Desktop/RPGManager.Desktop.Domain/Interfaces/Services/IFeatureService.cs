using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Features;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IFeatureService : ICrudServiceBase<Feature, FeatureRegisterDto, FeatureQueryDto>
{
}
