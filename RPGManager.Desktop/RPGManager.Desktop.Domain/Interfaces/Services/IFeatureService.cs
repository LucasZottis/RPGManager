using RPGManager.Desktop.Domain.DTOs.Features;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IFeatureService : ICrudServiceBase<Feature, FeatureRegisterDto, FeatureQueryDto>
{
}
