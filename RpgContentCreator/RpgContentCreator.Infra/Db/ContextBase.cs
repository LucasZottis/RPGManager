using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RpgContentCreator.Infra.Db.DbContextConfigurator;
using RpgContentCreator.Infra.Db.Interceptors;

namespace RpgContentCreator.Infra.Db;

public class ContextBase : DbContext
{
    private readonly ILogger _logger;
    private readonly DbContextConfiguratorBuilder _dbContextConfiguratorBuilder;

    public ContextBase( DbContextConfiguratorBuilder dbContextConfiguratorBuilder )
    {
        _dbContextConfiguratorBuilder = dbContextConfiguratorBuilder;
    }

    public ContextBase( ILogger logger, IConfiguration configuration ) : this( new DbContextConfiguratorBuilder( configuration ) )
    {
        _logger = logger;
    }

    //protected virtual void OnMappingEntities( ModelBuilder modelBuilder )
    //{
    //    EntityMapperBuilder.MapUsingEntityModelMapper( modelBuilder );
    //}

    protected override void OnConfiguring( DbContextOptionsBuilder dbContextOptionsBuilder )
    {
        _dbContextConfiguratorBuilder.AddContextOptionsBuilder( dbContextOptionsBuilder )
            .AddInterceptor( new UtcSaveChangesInterceptor() )
            .Build()
            .Configure();

        base.OnConfiguring( dbContextOptionsBuilder );
    }

    protected override void ConfigureConventions( ModelConfigurationBuilder configurationBuilder )
    {
        //if (AppSettings.GeneralSettings.DataBaseType == DataBaseType.PostgreSql )
        //{
        //    configurationBuilder.Properties<DateTime>().HaveColumnType( "timestamp without time zone" );
        //    configurationBuilder.Properties<DateTime?>().HaveColumnType( "timestamp without time zone" );
        //}
    }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        //OnMappingEntities( modelBuilder );
        base.OnModelCreating( modelBuilder );
    }

    public void CheckConnetion()
    {
        _logger.LogInformation( "Verificando conexão com o banco de dados..." );

        if ( !Database.CanConnect() )
            throw new Exception( "Não foi possível estabelecer conexão com o banco de dados." );

        _logger.LogInformation( "Conexão estabelecida!" );
    }
}