using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

namespace RPGManager.Desktop.Application.Services.RaceServices;

public class RaceSkillProficiencyChoiceService : CrudServiceBase<RaceSkillProficiencyChoice, RaceSkillProficiencyChoiceRegisterDto, RaceSkillProficiencyChoiceQueryDto>, IRaceSkillProficiencyChoiceService
{
    public RaceSkillProficiencyChoiceService( IRaceSkillProficiencyChoiceRepository repository, IRaceSkillProficiencyChoiceMapper mapper ) : base( repository, mapper )
    {
    }
}
