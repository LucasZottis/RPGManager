using RPGManager.Desktop.Domain.Entities.ClassesEntities.SkillProficiency;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ClassSkillProficiencyChoiceRepository : RepositoryBase<ClassSkillProficiencyChoice>, IClassSkillProficiencyChoiceRepository
{
    public ClassSkillProficiencyChoiceRepository( Context context ) : base( context )
    {
    }
}
