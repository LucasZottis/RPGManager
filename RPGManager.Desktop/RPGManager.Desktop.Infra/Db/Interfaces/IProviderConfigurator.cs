using Microsoft.EntityFrameworkCore;

namespace RPGManager.Desktop.Infra.Db.Interfaces;

public interface IProviderConfigurator
{
    public void Configure( DbContextOptionsBuilder builder );
}