using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Monsters;

namespace RPGManager.Desktop.Application.Services.MonsterServices;

public class MonsterService : CrudServiceBase<Monster, MonsterRegisterDto, MonsterQueryDto>, IMonsterService
{
    public MonsterService( IMonsterRepository repository, IMonsterMapper mapper ) : base( repository, mapper )
    {
    }
}
