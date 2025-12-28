using Microsoft.EntityFrameworkCore;

namespace RPGManager.Desktop.Infra.Db.Interfaces;

public interface IColumnTypeConfigurator
{
    void Configure( ModelConfigurationBuilder builder );
}