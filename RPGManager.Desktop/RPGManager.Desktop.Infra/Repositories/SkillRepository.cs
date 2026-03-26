using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class SkillRepository : RepositoryBase<Skill>, ISkillRepository
{
    public SkillRepository( Context context ) : base( context )
    {
    }
}
