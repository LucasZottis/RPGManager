namespace RPGManager.Desktop.Domain.Entities.Base;

//[PrimaryKey( nameof( Id ) )]
public class EntityBase
{
    //[Required]
    //[HasColumn( nameof( Id ), ColumnType.Guid )]
    public Guid Id { get; set; }
}