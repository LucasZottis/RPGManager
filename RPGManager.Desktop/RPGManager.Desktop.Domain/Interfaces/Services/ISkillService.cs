using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Skills;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ISkillService : ICrudServiceBase<Skill, SkillRegisterDto, SkillQueryDto>
{
}
