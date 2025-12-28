using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RPGManager.Desktop.Infra.Db.DbContextConfigurator;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.DI;

public static class DatabaseDependencyInjection
{
    public static IServiceCollection AddDatabase<TContext>( this IServiceCollection services, IConfiguration configuration )
        where TContext : DbContext
    {
        services.Configure<DataBaseSettings>( configuration.GetSection( DataBaseSettings.SettingsKey ) );
        services.Configure<ConnectionStrings>( configuration.GetSection( ConnectionStrings.SettingsKey ) );

        services.AddDbContext<TContext>();
        services.AddSingleton<IDbContextConfigurator, DbContextConfigurator>();
        //services.AddSingleton<ColumnTypeConfiguratorFactory>();

        return services;
    }
}