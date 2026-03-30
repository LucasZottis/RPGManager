using RPGManager.Desktop.Domain.Interfaces.UnitOfWork;
using RPGManager.Desktop.Infra.UnitsOfWork;
using System.Reflection;

namespace RPGManager.Desktop.Api.Utils.DI;

public static class UnitOfWorkDependencyInjection
{
    public static IServiceCollection AddUnitsOfWorkAsScoped( this IServiceCollection services, params Assembly[] assemblies )
    {
        var allTypes = assemblies.SelectMany( a => a.GetTypes() );
        var unitOfWorkImplementation = allTypes
            .Where( t => !t.IsAbstract && !t.IsInterface && IsSubclassOfRawGeneric( typeof( UnitOfWorkBase ), t ) );

        foreach ( var implementation in unitOfWorkImplementation )
        {
            var specificInterfaces = implementation.GetInterfaces()
                .Where( i =>
                {
                    if ( i.IsInterface )
                    {
                        return i.GetInterfaces().Any( parent =>
                        {
                            if ( parent.IsInterface )
                            {
                                return parent == typeof( IUnitOfWorkBase );
                            }

                            return false;
                        } );
                    }

                    return false;
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