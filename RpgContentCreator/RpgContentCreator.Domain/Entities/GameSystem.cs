namespace RpgContentCreator.Domain.Entities;

[PrimaryKey(nameof(Id))]
public class GameSystem : EntityBase
{
    [Required]
    [MaxLength( MaxLength.ShortName )]
    [HasColumn(nameof(Name), ColumnType.ShortText)]
    public string Name { get; set; }
}