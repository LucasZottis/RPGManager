using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Domain.Models.Items.Tools;

namespace RPGManager.Desktop.Application.Services;

public class ToolCategoryService : CrudServiceBase<ToolCategory, ToolCategoryRegisterDto, ToolCategoryQueryDto>, IToolCategoryService
{
    public ToolCategoryService( IToolCategoryRepository repository, IToolCategoryMapper mapper ) : base( repository, mapper )
    {
    }
}
