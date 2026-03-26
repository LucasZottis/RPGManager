using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceSkillProficiencyChoiceRepository : RepositoryBase<RaceSkillProficiencyChoice>, IRaceSkillProficiencyChoiceRepository
{
    public RaceSkillProficiencyChoiceRepository( Context context ) : base( context )
    {
    }
}
