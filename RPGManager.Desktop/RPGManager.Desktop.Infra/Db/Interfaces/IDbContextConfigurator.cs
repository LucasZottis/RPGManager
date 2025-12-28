using Microsoft.EntityFrameworkCore;

namespace RPGManager.Desktop.Infra.Db.Interfaces;

public interface IDbContextConfigurator
{
    //void Configure();
    IProviderConfigurator GetProviderConfigurator();
    IColumnTypeConfigurator GetColumnTypeConfigurator();
    INameConvetionConfigurator? GetNameConvetionConfigurator();
}