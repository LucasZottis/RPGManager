using RPGManager.Desktop.Domain.Models.Levels;

namespace RPGManager.Desktop.Application.Services;

public class LevelService : CrudServiceBase<Level, LevelRegisterDto, LevelQueryDto>, ILevelService
{
    public LevelService( ILevelRepository repository, ILevelMapper mapper ) : base( repository, mapper )
    {
    }
}
