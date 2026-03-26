namespace RPGManager.Desktop.Domain.Entities.Backgrounds;

public class BackgroundSkillProficiency
{
    public Guid BackgroundId { get; set; }
    public Guid SkillId { get; set; }

    public Background Background { get; set; }
    public Skill Skill { get; set; }
}