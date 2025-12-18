using Microsoft.EntityFrameworkCore;
using RpgContentCreator.Domain.Enums;
using RpgContentCreator.Infra.Helpers;
using System.Diagnostics;

namespace RpgContentCreator.Infra.Helpers;

internal static class DbProviderHelper
{
    ////private static void SetSqLiteProvider( this DbContextOptionsBuilder optionsBuilder, DataBaseType dataBaseType )
    ////{
    ////    var migrationAssembly = AppSettings.Assemblies.Migrations.FirstOrDefault( m => m.Contains( dataBaseType.ToString() ) );
    ////    var dataBaseFilePath = string.Empty;

    ////    if ( AppEnvironment.IsDevelopment() )
    ////        dataBaseFilePath = Environment.CurrentDirectory + "db";
    ////    else
    ////        dataBaseFilePath = AppContext.BaseDirectory + "db";

    ////    var connectionString = AppSettings.ConnectionStrings.GetConnectionString( dataBaseType )
    ////        .Replace( "${dataBaseDir}", dataBaseFilePath );

    ////    if ( !Directory.Exists( dataBaseFilePath + "\\" ) )
    ////        Directory.CreateDirectory( dataBaseFilePath + "\\" );

    ////    optionsBuilder.UseSqlite( connectionString, options
    ////        => options.MigrationsAssembly( migrationAssembly ) );
    ////}

    //private static void SetDbProvider( this DbContextOptionsBuilder optionsBuilder, DataBaseType dataBaseType )
    //{
    //    var connectionString = AppSettings.ConnectionStrings.GetConnectionString( dataBaseType );
    //    var migrationAssembly = AppSettings.Assemblies.Migrations.FirstOrDefault( m => m.Contains( dataBaseType.ToString() ) );

    //    switch ( dataBaseType )
    //    {
    //        case DataBaseType.SqlServer:
    //            optionsBuilder.UseSqlServer( connectionString, options => options.MigrationsAssembly( migrationAssembly ) );
    //            break;

    //        case DataBaseType.MySql:
    //            optionsBuilder.UseMySql(
    //                connectionString,
    //                ServerVersion.AutoDetect( connectionString ),
    //                options => options.MigrationsAssembly( migrationAssembly )
    //            );
    //            break;

    //        //case DataBaseType.SqLite:
    //        //    optionsBuilder.SetSqLiteProvider( dataBaseType );
    //        //    break;

    //        case DataBaseType.PostgreSql:
    //            optionsBuilder.UseNpgsql( connectionString, options =>
    //            {
    //                options.MigrationsAssembly( migrationAssembly );
    //            } ).UseSnakeCaseNamingConvention();

    //            break;
    //    }
    //}

    //public static void SetContextProvider( DbContextOptionsBuilder optionsBuilder )
    //{
    //    Debug.WriteLine( $"Inicializando: {nameof( SetContextProvider )}" );
    //    Debug.WriteLine( $"- {nameof( AppSettings.GeneralSettings.DataBaseType )}: {AppSettings.GeneralSettings.DataBaseType}" );
    //    var dataBaseType = AppSettings.GeneralSettings.DataBaseType;


    //    if ( dataBaseType == DataBaseType.InMemory )
    //        optionsBuilder.UseInMemoryDatabase( "DataBaseTest" );
    //    else
    //        optionsBuilder.SetDbProvider( dataBaseType );
    //}

    //public static void SetContextProvider( DbContextOptionsBuilder optionsBuilder, DataBaseType dataBaseType )
    //{
    //    if ( dataBaseType == DataBaseType.InMemory )
    //        optionsBuilder.UseInMemoryDatabase( "DataBaseTest" );
    //    else
    //        optionsBuilder.SetDbProvider( dataBaseType );
    //}
}