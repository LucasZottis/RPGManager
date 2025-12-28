using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.Provider;

public class ProviderConfigurator
{
    protected DataBaseSettings DataBaseSettings { get; private set; }

    public ProviderConfigurator(DataBaseSettings dataBaseSettings)
    {
        DataBaseSettings = dataBaseSettings;
    }

    protected string GetMigrationAssembly()
    {
        var migrationAssembly = $"{DataBaseSettings.MigrationAssembly}.{DataBaseSettings.DataBaseType.ToString()}";

        return migrationAssembly;
    }
}