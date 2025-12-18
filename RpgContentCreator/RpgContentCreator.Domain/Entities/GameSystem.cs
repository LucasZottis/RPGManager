namespace RpgContentCreator.Domain.Entities;

[PrimaryKey(nameof(Id))]
public class GameSystem
{
    public Guid Id { get; set; }

    [HasColumn(nameof(Name), ColumnType.ShortText)]
    [MaxLength( MaxLength.ShortName )]
    [Required]
    public string Name { get; set; }
}