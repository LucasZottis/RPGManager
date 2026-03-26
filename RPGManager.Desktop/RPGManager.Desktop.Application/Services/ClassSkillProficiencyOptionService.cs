using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassSkillProficiencyOptionService : CrudServiceBase<ClassSkillProficiencyOption, ClassSkillProficiencyOptionRegisterDto, ClassSkillProficiencyOptionQueryDto>, IClassSkillProficiencyOptionService
{
    public ClassSkillProficiencyOptionService( IClassSkillProficiencyOptionRepository repository, IClassSkillProficiencyOptionMapper mapper ) : base( repository, mapper )
    {
    }
}
