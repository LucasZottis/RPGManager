using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Domain.Models.Items.Tools;

namespace RPGManager.Desktop.Application.Services;

public class ToolService : CrudServiceBase<Tool, ToolRegisterDto, ToolQueryDto>, IToolService
{
    public ToolService( IToolRepository repository, IToolMapper mapper ) : base( repository, mapper )
    {
    }
}
