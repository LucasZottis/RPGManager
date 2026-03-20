namespace RPGManager.Desktop.Infra.Options;

public class ConnectionStrings
{
    public const string SettingsKey = "DataBaseSettings:ConnectionStrings";

    public string InMemory { get; set; }

    public string SqLite { get; set; }

    public string PostgreSql { get; set; }

    public string SqlServer { get; set; }
    public string MySql { get; set; }
    public string MariaDB { get; set; }
}