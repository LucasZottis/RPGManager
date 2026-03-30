using RPGManager.Desktop.Domain.Interfaces.Repositories;
using RPGManager.Desktop.Infra.Repositories;
using System.Reflection;

namespace RPGManager.Desktop.Api.Utils.DI;

public static class RepositoryDependencyInjection
{
    public static IServiceCollection AddRepositoriesAsScoped(
        this IServiceCollection services,
        params Assembly[] assemblies )
    {
        var allTypes = assemblies.SelectMany( a => a.GetTypes() );

        var repositoryImplementations = allTypes
            .Where( t =>
                !t.IsAbstract &&
                !t.IsInterface &&
                IsSubclassOfRawGeneric( typeof( RepositoryBase<> ), t ) );

        foreach ( var implementation in repositoryImplementations )
        {
            var specificInterfaces = implementation.GetInterfaces()
                .Where( i =>
                {
                    return i.IsInterface 
                        && i.GetInterfaces().Any( parent =>
                        {
                            return parent.IsGenericType
                                && parent.GetGenericTypeDefinition() == typeof( IRepositoryBase<> );
                        } );
                } );

            foreach ( var service in specificInterfaces )
                services.AddScoped( service, implementation );
        }

        return services;
    }

    private static bool IsSubclassOfRawGeneric( Type generic, Type type )
    {
        while ( type != null && type != typeof( object ) )
        {
            var current = type.IsGenericType
                ? type.GetGenericTypeDefinition()
                : type;

            if ( current == generic )
                return true;

            type = type.BaseType!;
        }

        return false;
    }
}
