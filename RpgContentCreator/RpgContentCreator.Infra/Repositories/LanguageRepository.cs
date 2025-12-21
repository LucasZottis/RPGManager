
namespace RpgContentCreator.Infra.Repositories;

public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
{
    public LanguageRepository( Context context ) : base( context )
    {
    }
}