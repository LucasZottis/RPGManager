namespace RpgContentCreator.Domain.Attributes;

public class HasColumnAttribute : ColumnAttribute
{
    public HasColumnAttribute( string name ) : base( name ) { }

    public HasColumnAttribute( string name, string columnType ) : this( name )
    {
        TypeName = columnType;
    }

    public HasColumnAttribute( string name, ColumnType columnType ) : this( name, ColumnTypeHelper.GetColumnType( columnType ) ) { }

    //private static string TransformName( string name )
    //{
    //    if ( AppSettings.GeneralSettings.DataBaseType == DataBaseType.PostgreSql )
    //        return name.ToLower();

    //    return name;
    //}
}