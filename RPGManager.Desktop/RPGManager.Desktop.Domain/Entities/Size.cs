using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities;

public class Size : GameSystemVersionEntityBase
{
    public string Name { get; set; }

    public float MinHeight { get; set; }
    public float MaxHeight { get; set; }
}