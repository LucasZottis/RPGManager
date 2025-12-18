using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RpgContentCreator.Domain.Entities;

public class Alignment : EntityBase
{
    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    [Required]
    [MaxLength(MaxLength.ShortName)]
    [HasColumn( nameof( Description ), ColumnType.ShortText )]
    public string Name { get; set; }

    [Required]
    [HasColumn(nameof( Description ), ColumnType.LongText )]
    public string Description { get; set; }

    public GameSystem GameSystem { get; set; }
}