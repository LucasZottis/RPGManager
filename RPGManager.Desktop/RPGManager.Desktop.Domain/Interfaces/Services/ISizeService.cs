using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Sizes;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ISizeService : ICrudServiceBase<Size, SizeRegisterDto, SizeQueryDto>
{
}
