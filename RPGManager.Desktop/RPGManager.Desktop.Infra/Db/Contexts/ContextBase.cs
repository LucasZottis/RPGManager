using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RPGManager.Desktop.Infra.Db.Interfaces;

namespace RPGManager.Desktop.Infra.Db.Contexts;

public class ContextBase : DbContext
{
    private readonly ILogger _logger;
    private readonly IServiceProvider _serviceProvider;

    public ContextBase( IServiceProvider serviceProvider )
    {
        _serviceProvider = serviceProvider;
    }

    protected override void OnConfiguring( DbContextOptionsBuilder builder )
    {
        var configurator = _serviceProvider.GetRequiredService<IProviderConfigurator>();
        configurator.Configure( builder );
        base.OnConfiguring( builder );
    }

    protected override void ConfigureConventions( ModelConfigurationBuilder builder )
    {
        var nameConventionConfigurator = _serviceProvider.GetRequiredService<INameConvetionConfigurator>();
        var columnTypeConfigurator = _serviceProvider.GetRequiredService<IColumnTypeConfigurator>();

        if ( nameConventionConfigurator.IsNotNull() )
            builder.Conventions.Add( _ => nameConventionConfigurator );

        columnTypeConfigurator.Configure( builder );

        base.ConfigureConventions( builder );
    }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        //modelBuilder.ApplyConfigurationsFromAssembly( Assembly.GetExecutingAssembly() );
        var configurator = _serviceProvider.GetRequiredService<EntityMapperConfigurator>();
        configurator.Configure( modelBuilder );
        base.OnModelCreating( modelBuilder );
    }

    public void CheckConnetion()
    {
        _logger?.LogInformation( "Verificando conexão com o banco de dados..." );

        if ( !Database.CanConnect() )
            throw new Exception( "Não foi possível estabelecer conexão com o banco de dados." );

        _logger?.LogInformation( "Conexão estabelecida!" );
    }
}