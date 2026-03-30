using Microsoft.Extensions.Options;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.NameConvetion;

public class NameConventionConfiguratorFactory
{
    private DataBaseSettings _dataBaseSettings;

    public NameConventionConfiguratorFactory(IOptions<DataBaseSettings> options)
    {
        _dataBaseSettings = options.Value;
    }

    public INameConvetionConfigurator? Create()
    {
        switch ( _dataBaseSettings.DataBaseType )
        {
            case Enums.DataBaseType.InMemory:
                return null;
            case Enums.DataBaseType.SqlServer:
                return null;
            case Enums.DataBaseType.MySql:
                return null;
            case Enums.DataBaseType.SqLite:
                return null;
            case Enums.DataBaseType.PostgreSql:
                return new PostegreSqlNameConvetionConfigurator();
            default:
                return null;
        }
    }
}