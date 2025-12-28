using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
{
    public LanguageRepository( Context context ) : base( context )
    {
    }
}