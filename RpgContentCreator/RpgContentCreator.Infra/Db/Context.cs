using Microsoft.EntityFrameworkCore;
using RpgContentCreator.Infra.Db.DbContextConfigurator;

namespace RpgContentCreator.Infra.Db;

public class Context : ContextBase
{
    internal DbSet<GameSystem> GameSystem { get; set; }

    public Context( DbContextConfiguratorBuilder dbContextConfiguratorBuilder ) : base( dbContextConfiguratorBuilder )
    {
    }
}