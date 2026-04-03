using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities;

public class Language : GameSystemVersionEntityBase
{    
    public string Name { get; set; }
    public string? Alphabet { get; set; }
}