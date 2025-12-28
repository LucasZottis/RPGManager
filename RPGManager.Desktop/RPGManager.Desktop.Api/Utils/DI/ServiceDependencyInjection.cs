using RPGManager.Desktop.Application.Services;
using System.Reflection;

namespace RPGManager.Desktop.Api.Utils.DI;

public static class ServiceDependencyInjection
{
    public static IServiceCollection AddServicesAsScoped(
        this IServiceCollection services,
        params Assembly[] assemblies )
    {
        var allTypes = assemblies.SelectMany( a => a.GetTypes() );
            //.Where( t => !t.IsAbstract && !t.IsInterface );

        var serviceImplementations = allTypes
            .Where( t =>
            {
                return IsSubclassOfRawGeneric( typeof( ServiceBase<,> ), t );
            } );

        foreach ( var implementation in serviceImplementations )
        {
            // Interfaces específicas que herdam de IServiceBase<,>
            var specificInterfaces = implementation.GetInterfaces()
                .Where( i =>
                {
                    return i.IsInterface
                        && i.GetInterfaces().Any( parent =>
                        {
                            return parent.IsGenericType
                                && parent.GetGenericTypeDefinition() == typeof( IServiceBase<,> );
                        } );
                } );

            foreach ( var service in specificInterfaces )
                services.AddScoped( service, implementation );

            // opcional: registrar o tipo concreto
            //services.AddScoped( implementation );
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