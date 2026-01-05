using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RPGManager.Desktop.Infra.Db.ColumnTypeConfigurator;

public class SqLiteColumnTypeConfigurator : ColumnTypeConfigurator
{
    protected override IDictionary<Type, Action<IConventionProperty>> GetTypes()
    {
        return new Dictionary<Type, Action<IConventionProperty>>()
        {
            [ typeof( bool ) ] = p => p.SetColumnType( "integer" ),

            [ typeof( short ) ] = p => p.SetColumnType( "integer" ),
            [ typeof( int ) ] = p => p.SetColumnType( "integer" ),
            [ typeof( long ) ] = p => p.SetColumnType( "integer" ),

            [ typeof( float ) ] = p => p.SetColumnType( "real" ),
            [ typeof( double ) ] = p => p.SetColumnType( "numeric" ),
            [ typeof( decimal ) ] = p => p.SetColumnType( "numeric" ),

            [ typeof( char ) ] = p => p.SetColumnType( "text(1)" ),
            [ typeof( string ) ] = p => p.SetColumnType( "text" ),

            [ typeof( Guid ) ] = p =>
            {
                p.SetColumnType( "text(36)" );
                p.SetCollation( "NOCASE" );
            },

            [ typeof( DateOnly ) ] = p => p.SetColumnType( "text" ),
            [ typeof( DateTime ) ] = p => p.SetColumnType( "text" ),
            [ typeof( TimeOnly ) ] = p => p.SetColumnType( "text" ),
            [ typeof( TimeSpan ) ] = p => p.SetColumnType( "text" ),
        };
    }
}