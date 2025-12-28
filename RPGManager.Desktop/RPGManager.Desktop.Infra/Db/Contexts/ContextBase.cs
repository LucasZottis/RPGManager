using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RPGManager.Desktop.Infra.Db.Interfaces;
using System.Reflection;

namespace RPGManager.Desktop.Infra.Db.Contexts;

public class ContextBase : DbContext
{
    private readonly ILogger _logger;
    private readonly IDbContextConfigurator _dbContextConfigurator;

    public ContextBase( IDbContextConfigurator dbContextConfigurator )
    {
        _dbContextConfigurator = dbContextConfigurator;
    }

    protected override void OnConfiguring( DbContextOptionsBuilder builder )
    {
        _dbContextConfigurator.GetProviderConfigurator().Configure( builder );
        base.OnConfiguring( builder );
    }

    protected override void ConfigureConventions( ModelConfigurationBuilder builder )
    {
        var nameConventionConfigurator = _dbContextConfigurator.GetNameConvetionConfigurator();

        if ( nameConventionConfigurator != null )
            builder.Conventions.Add( _ => nameConventionConfigurator );

        _dbContextConfigurator.GetColumnTypeConfigurator().Configure( builder );

        base.ConfigureConventions( builder );
    }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        modelBuilder.ApplyConfigurationsFromAssembly( Assembly.GetExecutingAssembly() );
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