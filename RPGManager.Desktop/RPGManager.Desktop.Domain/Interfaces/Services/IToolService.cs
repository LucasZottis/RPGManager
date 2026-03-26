using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Domain.Models.Items.Tools;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IToolService : ICrudServiceBase<Tool, ToolRegisterDto, ToolQueryDto>
{
}
