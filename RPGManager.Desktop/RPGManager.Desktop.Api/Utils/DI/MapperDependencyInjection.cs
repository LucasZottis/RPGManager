using RPGManager.Desktop.Application.Mappers.Base;
using RPGManager.Desktop.Domain.Interfaces.Mappers;
using System.Reflection;

namespace RPGManager.Desktop.Api.Utils.DI;

public static class MapperDependencyInjection
{
    public static IServiceCollection AddMappersAsSingleton(
        this IServiceCollection services,
        params Assembly[] assemblies )
    {
        var allTypes = assemblies.SelectMany( a => a.GetTypes() );

        var mapperImplementations = allTypes
            .Where( t =>
                !t.IsAbstract &&
                !t.IsInterface &&
                //IsSubclassOfRawGeneric( typeof( Mapper<,> ), t ) );
                IsSubclassOfRawGeneric( typeof( MapperTwo<> ), t ) );

        foreach ( var implementation in mapperImplementations )
        {
            // Interfaces específicas que herdam de IMapper<,>
            var specificInterfaces = implementation.GetInterfaces()
                .Where( i =>
                    i.IsInterface &&
                    i.GetInterfaces().Any( parent =>
                        parent.IsGenericType &&
                        //parent.GetGenericTypeDefinition() == typeof( IMapper<,> )
                        parent.GetGenericTypeDefinition() == typeof( IMapperTwo<> )
                    ) );

            foreach ( var service in specificInterfaces )
            {
                services.AddSingleton( service, implementation );
            }

            // opcional: registrar o tipo concreto
            //services.AddSingleton( implementation );
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
