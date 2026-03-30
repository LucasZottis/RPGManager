using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.AbilityScores;

namespace RPGManager.Desktop.Application.Services;

public class AbilityScoreService : CrudServiceBase<AbilityScore, AbilityScoreRegisterDto, AbilityScoreQueryDto>, IAbilityScoreService
{
    public AbilityScoreService( IAbilityScoreRepository repository, IAbilityScoreMapper mapper ) : base( repository, mapper )
    {
    }
}