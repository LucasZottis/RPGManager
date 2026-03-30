using RPGManager.Desktop.Domain.DTOs.Items.Tools;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.ItemServices.ToolServices;

public interface IToolCategoryService : ICrudServiceBase<ToolCategory, ToolCategoryRegisterDto, ToolCategoryQueryDto>
{
}
