using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IBackgroundToolProficiencyService : ICrudServiceBase<BackgroundToolProficiency, BackgroundToolProficiencyRegisterDto, BackgroundToolProficiencyQueryDto>
{
}
