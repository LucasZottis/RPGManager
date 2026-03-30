using RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.BackgroundRepositories;

public class BackgroundAbilityScoreChoiceRepository : RepositoryBase<BackgroundAbilityScoreChoice>, IBackgroundAbilityScoreChoiceRepository
{
    public BackgroundAbilityScoreChoiceRepository( Context context ) : base( context )
    {
    }
}
