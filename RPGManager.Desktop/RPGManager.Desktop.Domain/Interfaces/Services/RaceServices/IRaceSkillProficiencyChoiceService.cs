using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

public interface IRaceSkillProficiencyChoiceService : ICrudServiceBase<RaceSkillProficiencyChoice, RaceSkillProficiencyChoiceRegisterDto, RaceSkillProficiencyChoiceQueryDto>
{
}
