using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.RaceRepositories;

public class RaceLanguageRepository : RepositoryBase<RaceLanguage>, IRaceLanguageRepository
{
    public RaceLanguageRepository( Context context ) : base( context )
    {
    }
}
