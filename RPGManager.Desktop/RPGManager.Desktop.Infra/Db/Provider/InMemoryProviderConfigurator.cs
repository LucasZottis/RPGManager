using Microsoft.EntityFrameworkCore;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.Provider;

public class InMemoryProviderConfigurator : ProviderConfigurator, IProviderConfigurator
{
    public InMemoryProviderConfigurator( DataBaseSettings dataBaseSettings ) : base( dataBaseSettings )
    {
    }

    public void Configure( DbContextOptionsBuilder builder )
    {
        var connectionString = DataBaseSettings.ConnectionStrings.InMemory;

        builder.UseInMemoryDatabase( connectionString, i => i.EnableNullChecks() );
    }
}