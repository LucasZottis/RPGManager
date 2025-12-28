using Microsoft.Extensions.Options;
using RPGManager.Desktop.Infra.Db.Enums;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.Provider;

public class ProviderConfiguratorFactory
{
    private readonly DataBaseSettings _dataBaseSettings;

    public ProviderConfiguratorFactory( IOptions<DataBaseSettings> options )
    {
        _dataBaseSettings = options.Value;
    }

    public IProviderConfigurator Create()
    {
        switch ( _dataBaseSettings.DataBaseType )
        {
            default:
            case DataBaseType.InMemory:
                return new InMemoryProviderConfigurator( _dataBaseSettings );
            case DataBaseType.SqlServer:
            case DataBaseType.MySql:
                throw new Exception( "Não há um provider implementado para esse tipo de banco de dados" );
            case DataBaseType.SqLite:
                return new SqLiteProviderConfigurator( _dataBaseSettings );
            case DataBaseType.PostgreSql:
                return new PostegreSqlProviderConfigurator( _dataBaseSettings );
        }
    }
}