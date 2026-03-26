using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;

namespace RPGManager.Desktop.Application.Services;

public class RaceSkillProficiencyChoiceService : CrudServiceBase<RaceSkillProficiencyChoice, RaceSkillProficiencyChoiceRegisterDto, RaceSkillProficiencyChoiceQueryDto>, IRaceSkillProficiencyChoiceService
{
    public RaceSkillProficiencyChoiceService( IRaceSkillProficiencyChoiceRepository repository, IRaceSkillProficiencyChoiceMapper mapper ) : base( repository, mapper )
    {
    }
}
