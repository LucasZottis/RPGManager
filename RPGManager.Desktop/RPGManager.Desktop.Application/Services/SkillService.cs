using RPGManager.Desktop.Domain.Models.Skills;

namespace RPGManager.Desktop.Application.Services;

public class SkillService : CrudServiceBase<Skill, SkillRegisterDto, SkillQueryDto>, ISkillService
{
    public SkillService( ISkillRepository repository, ISkillMapper mapper ) : base( repository, mapper )
    {
    }
}
