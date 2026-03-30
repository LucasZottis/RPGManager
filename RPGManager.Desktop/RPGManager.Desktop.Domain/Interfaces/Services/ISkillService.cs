using RPGManager.Desktop.Domain.DTOs.Skills;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ISkillService : ICrudServiceBase<Skill, SkillRegisterDto, SkillQueryDto>
{
}
