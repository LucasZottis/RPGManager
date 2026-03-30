using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Items.Tools;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.ItemServices.ToolServices;

namespace RPGManager.Desktop.Application.Services.ItemServices.ToolServices;

public class ToolCategoryService : CrudServiceBase<ToolCategory, ToolCategoryRegisterDto, ToolCategoryQueryDto>, IToolCategoryService
{
    public ToolCategoryService( IToolCategoryRepository repository, IToolCategoryMapper mapper ) : base( repository, mapper )
    {
    }
}
