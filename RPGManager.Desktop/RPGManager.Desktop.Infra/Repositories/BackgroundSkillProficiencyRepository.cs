using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class BackgroundSkillProficiencyRepository : RepositoryBase<BackgroundSkillProficiency>, IBackgroundSkillProficiencyRepository
{
    public BackgroundSkillProficiencyRepository( Context context ) : base( context )
    {
    }
}
