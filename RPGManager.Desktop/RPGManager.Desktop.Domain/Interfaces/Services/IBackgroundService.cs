using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IBackgroundService : ICrudServiceBase<Background, BackgroundRegisterDto, BackgroundQueryDto>
{

}