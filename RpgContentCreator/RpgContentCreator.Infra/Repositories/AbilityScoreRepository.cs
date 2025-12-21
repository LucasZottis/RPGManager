
namespace RpgContentCreator.Infra.Repositories;

public class AbilityScoreRepository : RepositoryBase<AbilityScore>, IAbilityScoreRepository
{
    public AbilityScoreRepository( Context context ) : base( context )
    {
    }
}