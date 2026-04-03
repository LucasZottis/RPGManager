//using RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;
//using RPGManager.Desktop.Domain.Entities.Backgrounds.Equipments;
//using RPGManager.Desktop.Domain.Entities.Backgrounds.ToolProficiencies;
//using RPGManager.Desktop.Domain.Entities.Base;

//namespace RPGManager.Desktop.Domain.Entities.Backgrounds;

//public class Background : GameSystemVersionEntityBase
//{
//    public string Name { get; set; }
//    public string? Description { get; set; }

//    public BackgroundAbilityScoreChoice AbilityScoreChoice { get; set; }
//    public BackgroundToolProficiency? ToolProficiency { get; set; }
//    public BackgroundToolProficiencyChoice? ToolProficiencyChoice { get; set; }

//    public ICollection<BackgroundSkillProficiency> SkillProficiencies { get; set; }
//    public ICollection<BackgroundEquipmentOption> EquipmentOptions { get; set; }
//}