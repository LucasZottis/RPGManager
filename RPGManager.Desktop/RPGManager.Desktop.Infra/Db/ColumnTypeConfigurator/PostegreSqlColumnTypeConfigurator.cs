using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RPGManager.Desktop.Infra.Db.ColumnTypeConfigurator;

public class PostegreSqlColumnTypeConfigurator : ColumnTypeConfigurator
{
    protected override IDictionary<Type, Action<IConventionProperty>> GetTypes()
    {
        return new Dictionary<Type, Action<IConventionProperty>>()
        {
            [ typeof( bool ) ] = p => p.SetColumnType( "boolean" ),

            [ typeof( short ) ] = p => p.SetColumnType( "smallint" ),
            [ typeof( int ) ] = p => p.SetColumnType( "integer" ),
            [ typeof( long ) ] = p => p.SetColumnType( "bigint" ),

            [ typeof( float ) ] = p => p.SetColumnType( "real" ),
            [ typeof( double ) ] = p => p.SetColumnType( "double precision" ),
            [ typeof( decimal ) ] = p => p.SetColumnType( "decimal" ),

            [ typeof( char ) ] = p => p.SetColumnType( "varchar(1)" ),
            [ typeof( string ) ] = p => p.SetColumnType( "varchar" ),

            [ typeof( Guid ) ] = p => p.SetColumnType( "uuid" ),
            [ typeof( DateOnly ) ] = p => p.SetColumnType( "date" ),
            [ typeof( DateTime ) ] = p => p.SetColumnType( "timestamp without time zone" ),
            [ typeof( TimeOnly ) ] = p => p.SetColumnType( "time without time zone" ),
            [ typeof( TimeSpan ) ] = p => p.SetColumnType( "time without time zone" ),
        };
    }
}