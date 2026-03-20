using Microsoft.EntityFrameworkCore;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.Provider;

public class PostegreSqlProviderConfigurator : ProviderConfigurator, IProviderConfigurator
{
    public PostegreSqlProviderConfigurator( DataBaseSettings dataBaseSettings ) : base( dataBaseSettings )
    {
    }

    public void Configure( DbContextOptionsBuilder builder )
    {
        var migrationAssembly = GetMigrationAssembly();
        var connectionString = DataBaseSettings.ConnectionStrings.PostgreSql;

        builder.UseNpgsql( connectionString, options => options.MigrationsAssembly( migrationAssembly ) );
    }
}