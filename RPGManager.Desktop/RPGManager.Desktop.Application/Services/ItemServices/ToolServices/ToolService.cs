using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Items.Tools;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.ItemServices.ToolServices;

namespace RPGManager.Desktop.Application.Services.ItemServices.ToolServices;

public class ToolService : CrudServiceBase<Tool, ToolRegisterDto, ToolQueryDto>, IToolService
{
    public ToolService( IToolRepository repository, IToolMapper mapper ) : base( repository, mapper )
    {
    }
}
