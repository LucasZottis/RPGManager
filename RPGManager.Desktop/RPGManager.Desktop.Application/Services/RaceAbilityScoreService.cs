namespace RPGManager.Desktop.Application.Services;

public class RaceAbilityScoreService : CrudServiceBase<RaceAbilityScore, RaceAbilityScoreRegisterDto, RaceAbilityScoreQueryDto>, IRaceAbilityScoreService
{
    public RaceAbilityScoreService( IRaceAbilityScoreRepository repository, IRaceAbilityScoreMapper mapper ) : base( repository, mapper )
    {
    }
}
