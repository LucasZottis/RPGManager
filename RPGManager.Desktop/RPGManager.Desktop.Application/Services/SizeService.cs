using RPGManager.Desktop.Domain.Models.Sizes;

namespace RPGManager.Desktop.Application.Services;

public class SizeService : CrudServiceBase<Size, SizeRegisterDto, SizeQueryDto>, ISizeService
{
    public SizeService( ISizeRepository repository, ISizeMapper mapper ) : base( repository, mapper )
    {
    }
}
