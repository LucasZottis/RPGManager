using RPGManager.Desktop.Domain.DTOs.Sizes;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ISizeService : ICrudServiceBase<Size, SizeRegisterDto, SizeQueryDto>
{
}
