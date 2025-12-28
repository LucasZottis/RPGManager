using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using RPGManager.Desktop.Infra.Db.ColumnTypeConfigurator;
using RPGManager.Desktop.Infra.Db.Interfaces;
using RPGManager.Desktop.Infra.Db.NameConvetion;
using RPGManager.Desktop.Infra.Db.Provider;
using RPGManager.Desktop.Infra.Options;

namespace RPGManager.Desktop.Infra.Db.DbContextConfigurator;

public class DbContextConfigurator : IDbContextConfigurator
{
    private readonly ProviderConfiguratorFactory _providerConfiguratorFactory;
    private readonly ColumnTypeConfiguratorFactory _columnTypeConfiguratorFactory;
    private readonly NameConventionConfiguratorFactory _nameConventionConfiguratorFactory;

    public DbContextOptionsBuilder DbContextOptionsBuilder { get; set; }

    public IList<IInterceptor> Interceptors { get; } = new List<IInterceptor>();

    public DbContextConfigurator( IOptions<DataBaseSettings> options )
    {
        _providerConfiguratorFactory = new( options );
        _columnTypeConfiguratorFactory = new( options );
        _nameConventionConfiguratorFactory = new( options );
    }

    public IProviderConfigurator GetProviderConfigurator()
    {
        return _providerConfiguratorFactory.Create();
    }

    public IColumnTypeConfigurator GetColumnTypeConfigurator()
    {
        return _columnTypeConfiguratorFactory.Create();
    }

    public INameConvetionConfigurator? GetNameConvetionConfigurator()
    {
        return _nameConventionConfiguratorFactory.Create();
    }
}