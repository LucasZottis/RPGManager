using System.Diagnostics.CodeAnalysis;

namespace RPGManager.Desktop.Infra.Utils;

public static class ThrowHelper
{
    [DoesNotReturn]
    public static void ThrowNullEntity<TEntity>( TEntity entity )
    {
        if ( entity == null )
        {
            var entityName = typeof( TEntity ).Name;
            throw new NullReferenceException( $"{entityName} não pode ser nulo" );
        }
    }
}