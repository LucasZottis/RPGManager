using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;
using System.Reflection;

public static class ServiceDependencyInjection
{
    public static IServiceCollection AddServicesAsScoped(
        this IServiceCollection services,
        params Assembly[] assemblies )
    {
        var allTypes = assemblies.SelectMany( a => a.GetTypes() );

        var serviceImplementations = allTypes
            .Where( t =>
                !t.IsAbstract &&
                !t.IsInterface &&
                InheritsFromServiceBase( t ) );

        foreach ( var implementation in serviceImplementations )
        {
            var specificInterfaces = implementation.GetInterfaces()
                .Where( i =>
                    i.IsInterface &&
                    InheritsFromIServiceBase( i ) );

            foreach ( var service in specificInterfaces )
                services.AddScoped( service, implementation );
        }

        return services;
    }

    private static bool InheritsFromServiceBase( Type type )
    {
        var current = type.BaseType;
        while ( current != null && current != typeof( object ) )
        {
            if ( current == typeof( ServiceBase ) ||
                 ( current.IsGenericType && current.GetGenericTypeDefinition() == typeof( ServiceBase ) ) )
                return true;

            current = current.BaseType;
        }
        return false;
    }

    private static bool InheritsFromIServiceBase( Type interfaceType )
    {
        return interfaceType.GetInterfaces()
            .Any( parent => parent == typeof( IServiceBase ) || InheritsFromIServiceBase( parent ) );
    }
}