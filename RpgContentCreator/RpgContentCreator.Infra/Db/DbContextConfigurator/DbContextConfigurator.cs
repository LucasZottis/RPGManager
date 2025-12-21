using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using RpgContentCreator.Domain.Enums;
using RpgContentCreator.Infra.Extensions;
using RpgContentCreator.Infra.Interfaces;
using System.Reflection;

namespace RpgContentCreator.Infra.Db.DbContextConfigurator;

public class DbContextConfigurator : IDbContextConfigurator
{
    private readonly IConfiguration _configuration;

    public DbContextOptionsBuilder DbContextOptionsBuilder { get; set; }

    public IList<IInterceptor> Interceptors { get; } = new List<IInterceptor>();

    public DbContextConfigurator( IConfiguration configuration )
    {
        _configuration = configuration;
    }

    private string GetMigrationAssembly( DataBaseType dataBaseType )
    {
        var baseNameAssembly = Assembly.GetEntryAssembly().GetName().Name.Split( "." );
        var migrationAssembly = $"{baseNameAssembly}.Migration.{dataBaseType.ToString()}";

        return migrationAssembly;
    }

    private void SetSqLiteProvider( DataBaseType dataBaseType )
    {
        var dataBaseFilePath = _configuration.GetConnectionString( dataBaseType.ToString() );

        if ( !Directory.Exists( dataBaseFilePath + "\\" ) )
            Directory.CreateDirectory( dataBaseFilePath + "\\" );

        DbContextOptionsBuilder.UseSqlite( dataBaseFilePath, options
            => options.MigrationsAssembly( GetMigrationAssembly( dataBaseType ) ) );
    }

    private void SetPostegreSqlProvider( DataBaseType dataBaseType )
    {
        var connectionString = _configuration.GetConnectionString( dataBaseType.ToString() );
        //var migrationAssembly = _configuration.GetRequiredSection( "MigrationAssembly" ).Value;

        DbContextOptionsBuilder.UseNpgsql( connectionString, options =>
        {
            options.MigrationsAssembly( GetMigrationAssembly( dataBaseType ) );
        } ).UseSnakeCaseNamingConvention();
    }

    private void SetSqlServerProvider( DataBaseType dataBaseType )
    {
        //var connectionString = AppSettings.ConnectionStrings.GetConnectionString( dataBaseType );
        //var migrationAssembly = AppSettings.Assemblies.Migrations.FirstOrDefault( m => m.Contains( dataBaseType.ToString() ) );
        var connectionString = _configuration.GetConnectionString( dataBaseType.ToString() );
        //var migrationAssembly = _configuration.GetRequiredSection( "MigrationAssembly" ).Value;

        DbContextOptionsBuilder.UseSqlServer( connectionString, options => options.MigrationsAssembly( GetMigrationAssembly( dataBaseType ) ) );
    }

    private void SetInMemoryProvider()
    {
        DbContextOptionsBuilder.UseInMemoryDatabase( "RPGManagerDB", i => i.EnableNullChecks() );
    }

    private void SetDbProvider()
    {
        var dataBaseType = _configuration.GetDataBaseType();

        switch ( dataBaseType )
        {
            case DataBaseType.SqlServer:
                SetSqlServerProvider( dataBaseType );
                break;

            //case DataBaseType.MySql:
            //    optionsBuilder.UseMySql(
            //        connectionString,
            //        ServerVersion.AutoDetect( connectionString ),
            //        options => options.MigrationsAssembly( migrationAssembly )
            //    );
            //    break;

            case DataBaseType.SqLite:
                SetSqLiteProvider( dataBaseType );
                break;

            case DataBaseType.PostgreSql:
                SetPostegreSqlProvider( dataBaseType );
                break;

            default:
                SetInMemoryProvider();
                break;
        }
    }

    private void AddInterceptors()
    {
        DbContextOptionsBuilder.AddInterceptors( Interceptors );
    }

    public void Configure()
    {
        SetDbProvider();
        AddInterceptors();
    }
}