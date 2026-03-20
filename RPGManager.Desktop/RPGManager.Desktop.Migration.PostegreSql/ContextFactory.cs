//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Options;
//using RPGManager.Desktop.Infra.Db.Contexts;
//using RPGManager.Desktop.Infra.Db.DbContextConfigurator;
//using RPGManager.Desktop.Infra.Db.Enums;
//using RPGManager.Desktop.Infra.Options;

//namespace RPGManager.Desktop.SqLite;

//public class ContextFactory : IDesignTimeDbContextFactory<Context>
//{
//    public Context CreateDbContext( string[] args )
//    {
//        var options = Options.Create( new DataBaseSettings
//        {
//            DataBaseType = DataBaseType.SqLite,
//            ConnectionStrings = new ConnectionStrings
//            {
//                SqLite = $"Data Source={AppContext.BaseDirectory}\\DB\\rpg_manager.db"
//            }
//        } );

//        return new Context(
//            new DbContextConfigurator( options )
//        );
//    }
//}

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RPGManager.Desktop.Infra.Db.Contexts;
using RPGManager.Desktop.Infra.Db.DbContextConfigurator;
using RPGManager.Desktop.Infra.Options;

public class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext( string[] args )
    {
        Console.WriteLine( $"Base path: {Directory.GetCurrentDirectory()}" );

        var config = new ConfigurationBuilder()
            .SetBasePath( Directory.GetCurrentDirectory() )
            .AddJsonFile( "appsettings.json", optional: false )
            .AddJsonFile( "appsettings.Development.json", optional: true )
            .AddEnvironmentVariables()
            .Build();

        var settings = config.GetSection( DataBaseSettings.SettingsKey )
                             .Get<DataBaseSettings>();

        //Console.WriteLine( $"DataBaseType: {settings?.DataBaseType}" );
        //Console.WriteLine( $"ConnectionString: {settings?.ConnectionStrings?.PostegreSql}" );

        var options = Options.Create( settings! );

        return new Context( new DbContextConfigurator( options ) );
    }
}