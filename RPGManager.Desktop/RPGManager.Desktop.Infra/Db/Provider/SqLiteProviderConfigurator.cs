using Microsoft.EntityFrameworkCore;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.Provider;

public class SqLiteProviderConfigurator : ProviderConfigurator, IProviderConfigurator
{
    public SqLiteProviderConfigurator( DataBaseSettings dataBaseSettings ) : base( dataBaseSettings )
    {
    }

    private void EnsureDatabasePathExists(string connectionString)
    {
        // extrai o caminho do arquivo a partir da connection string
        var sqliteConnectionStringBuilder = new Microsoft.Data.Sqlite.SqliteConnectionStringBuilder( connectionString );
        var dbFilePath = sqliteConnectionStringBuilder.DataSource;

        // resolve caminho relativo → absoluto
        var fullPath = Path.GetFullPath( dbFilePath );

        // cria o diretório (se não existir)
        var directory = Path.GetDirectoryName( fullPath )!;
        Directory.CreateDirectory( directory );
    }

    public void Configure( DbContextOptionsBuilder builder )
    {
        var migrationAssembly = GetMigrationAssembly();
        var connectionString = DataBaseSettings.ConnectionStrings.SqLite;

        if ( connectionString.IsEmpty() )
        {
            var dataBaseFilePath = $@"{AppContext.BaseDirectory}SQLite\";

            if ( !Directory.Exists( dataBaseFilePath ) )
                Directory.CreateDirectory( dataBaseFilePath );

            connectionString = $"Data Source={dataBaseFilePath}data_base.db";
        }

        EnsureDatabasePathExists( connectionString );

        // usa a string ORIGINAL, sem modificar
        builder.UseSqlite( connectionString, options => options.MigrationsAssembly( migrationAssembly ) );
    }
}