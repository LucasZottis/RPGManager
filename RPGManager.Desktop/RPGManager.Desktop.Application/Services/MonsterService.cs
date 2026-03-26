using RPGManager.Desktop.Domain.Models.Monsters;

namespace RPGManager.Desktop.Application.Services;

public class MonsterService : CrudServiceBase<Monster, MonsterRegisterDto, MonsterQueryDto>, IMonsterService
{
    public MonsterService( IMonsterRepository repository, IMonsterMapper mapper ) : base( repository, mapper )
    {
    }
}
