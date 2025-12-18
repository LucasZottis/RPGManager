using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using RpgContentCreator.Infra.Interfaces;

namespace RpgContentCreator.Infra.Db.DbContextConfigurator;

public class DbContextConfiguratorBuilder
{
    private readonly DbContextConfigurator _configurator;

    public DbContextConfiguratorBuilder( IConfiguration configuration )
    {
        _configurator = new DbContextConfigurator( configuration );
    }

    public DbContextConfiguratorBuilder AddContextOptionsBuilder( DbContextOptionsBuilder dbContextOptionsBuilder )
    {
        if ( _configurator.DbContextOptionsBuilder == null )
            _configurator.DbContextOptionsBuilder = dbContextOptionsBuilder;

        return this;
    }

    public DbContextConfiguratorBuilder AddInterceptor( IInterceptor  interceptor )
    {
        _configurator.Interceptors.Add( interceptor );
        return this;
    }

    public IDbContextConfigurator Build()
    {
        return _configurator;
    }
}