using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RPGManager.Desktop.Infra.Db.ColumnTypeConfigurator;
using RPGManager.Desktop.Infra.Db.NameConvetion;
using RPGManager.Desktop.Infra.Db.Provider;
using RPGManager.Desktop.Infra.Options;
using System.Reflection;

namespace RPGManager.Desktop.Infra.DI;

public static class DatabaseDependencyInjection
{
    private static IServiceCollection AddProviderConfigurator( IServiceCollection services )
    {
        services.AddSingleton<ProviderConfiguratorFactory>();
        services.AddSingleton( provider =>
        {
            var factory = provider.GetRequiredService<ProviderConfiguratorFactory>();
            return factory.Create();
        } );

        return services;
    }

    private static IServiceCollection AddColumnTypeConfigurator( IServiceCollection services )
    {
        services.AddSingleton<ColumnTypeConfiguratorFactory>();
        services.AddSingleton( provider =>
        {
            var factory = provider.GetRequiredService<ColumnTypeConfiguratorFactory>();
            return factory.Create();
        } );

        return services;
    }

    private static IServiceCollection AddNameConvetionConfigurator( IServiceCollection services )
    {
        services.AddSingleton<NameConventionConfiguratorFactory>();
        services.AddSingleton( provider =>
        {
            var factory = provider.GetRequiredService<NameConventionConfiguratorFactory>();
            return factory.Create();
        } );

        return services;
    }

    private static IServiceCollection AddEntityMapper( IServiceCollection services )
    {
        services.AddSingleton<EntityMapperConfigurator>();

        var assembly = Assembly.GetExecutingAssembly();
        var mapperTypes = assembly.GetTypes()
            .Where( t => !t.IsAbstract && !t.IsInterface )
            .Where( t => t.GetInterfaces()
                .Any( i => i.IsGenericType &&
                           i.GetGenericTypeDefinition() == typeof( IEntityTypeConfiguration<> ) ) );

        foreach ( var mapperType in mapperTypes )
        {
            var serviceType = mapperType.GetInterfaces()
                .First( i => i.IsGenericType &&
                             i.GetGenericTypeDefinition() == typeof( IEntityTypeConfiguration<> ) );

            // Registra pela interface construída IEntityTypeConfiguration<TEntity>
            services.AddSingleton( serviceType, mapperType );
        }

        return services;
    }

    public static IServiceCollection AddDatabase<TContext>( this IServiceCollection services, IConfiguration configuration )
        where TContext : DbContext
    {
        services.Configure<DataBaseSettings>( configuration.GetSection( DataBaseSettings.SettingsKey ) );
        services.Configure<ConnectionStrings>( configuration.GetSection( ConnectionStrings.SettingsKey ) );

        services.AddDbContext<TContext>();

        AddProviderConfigurator( services );
        AddColumnTypeConfigurator( services );
        AddNameConvetionConfigurator( services );
        AddEntityMapper( services );

        return services;
    }
}