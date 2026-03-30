namespace RPGManager.Desktop.Domain.DTOs.Classes;

public class ClassFeatureRegisterDto
{
    public Guid ClassLevelId { get; set; }
    public Guid? ParentClassFeatureId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
