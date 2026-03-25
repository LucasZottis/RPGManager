using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities;

public class Alignment : GameSystemEntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
}