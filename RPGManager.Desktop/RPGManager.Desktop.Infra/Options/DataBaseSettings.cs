using RPGManager.Desktop.Infra.Db.Enums;

namespace RPGManager.Desktop.Infra.Options;

public class DataBaseSettings
{
    public const string SettingsKey = "DataBaseSettings";

    public DataBaseType DataBaseType { get; set; } = DataBaseType.InMemory;
    public string MigrationAssembly { get; set; }

    public ConnectionStrings ConnectionStrings { get; set; } = new();
}