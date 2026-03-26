using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceSkillProficiencyOptionRepository : RepositoryBase<RaceSkillProficiencyOption>, IRaceSkillProficiencyOptionRepository
{
    public RaceSkillProficiencyOptionRepository( Context context ) : base( context )
    {
    }
}
