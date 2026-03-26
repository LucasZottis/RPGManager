using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class BackgoundToolProficiencyRepository : RepositoryBase<BackgroundToolProficiency>, IBackgoundToolProficiencyRepository
{
    public BackgoundToolProficiencyRepository( Context context ) : base( context )
    {
    }
}
