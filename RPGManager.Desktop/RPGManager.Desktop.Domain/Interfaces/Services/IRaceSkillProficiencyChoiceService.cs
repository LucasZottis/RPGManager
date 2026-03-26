using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Domain.Models.Races;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IRaceSkillProficiencyChoiceService : ICrudServiceBase<RaceSkillProficiencyChoice, RaceSkillProficiencyChoiceRegisterDto, RaceSkillProficiencyChoiceQueryDto>
{
}
