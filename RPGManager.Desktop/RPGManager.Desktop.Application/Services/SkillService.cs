using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Skills;

namespace RPGManager.Desktop.Application.Services;

public class SkillService : CrudServiceBase<Skill, SkillRegisterDto, SkillQueryDto>, ISkillService
{
    public SkillService( ISkillRepository repository, ISkillMapper mapper ) : base( repository, mapper )
    {
    }
}
