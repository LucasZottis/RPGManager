namespace RpgContentCreator.Domain.Entities;

public class DamageType : EntityBase
{
    [Required]
    [MaxLength(MaxLength.ShortName)]
    [HasColumn(nameof(Name), ColumnType.ShortText)]
    public string Name { get; set; }
}