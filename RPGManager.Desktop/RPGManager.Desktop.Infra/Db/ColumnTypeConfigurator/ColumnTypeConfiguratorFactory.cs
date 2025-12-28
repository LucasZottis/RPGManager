using Microsoft.Extensions.Options;
using RPGManager.Desktop.Infra.Db.Enums;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.ColumnTypeConfigurator;

public class ColumnTypeConfiguratorFactory
{
    private DataBaseType _dataBaseType = DataBaseType.InMemory;

    public ColumnTypeConfiguratorFactory( IOptions<DataBaseSettings> options )
    {
        _dataBaseType = options.Value.DataBaseType;
    }

    public IColumnTypeConfigurator? Create()
    {
        switch ( _dataBaseType )
        {
            case DataBaseType.SqLite:
                return new SqLiteColumnTypeConfigurator();
            case DataBaseType.PostgreSql:
                return new PostegreSqlColumnTypeConfigurator();
            case DataBaseType.InMemory:
                return null;
            case DataBaseType.SqlServer:
            case DataBaseType.MySql:
            default:
                throw new NotImplementedException( "Não foi implementado Resolver para o banco informado." );
        }
    }
}