using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Runtime.CompilerServices;

public class EntityMapperConfigurator
{
    private readonly IServiceProvider _serviceProvider;

    public EntityMapperConfigurator( IServiceProvider serviceProvider )
    {
        _serviceProvider = serviceProvider;
    }

    public void Configure( ModelBuilder modelBuilder )
    {
        var mapperTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where( t => !t.IsAbstract && !t.IsInterface )
            .Where( t => t.GetInterfaces()
                .Any( i => i.IsGenericType &&
                           i.GetGenericTypeDefinition() == typeof( IEntityTypeConfiguration<> ) ) );

        var applyConfiguration = typeof( ModelBuilder )
            .GetMethods()
            .First( m => m.Name == nameof( ModelBuilder.ApplyConfiguration ) &&
                         m.GetParameters()[ 0 ].ParameterType.GetGenericTypeDefinition() == typeof( IEntityTypeConfiguration<> ) );

        foreach ( var mapperType in mapperTypes )
        {
            var serviceType = mapperType.GetInterfaces()
                .First( i => i.IsGenericType &&
                             i.GetGenericTypeDefinition() == typeof( IEntityTypeConfiguration<> ) );

            var entityType = serviceType.GetGenericArguments()[ 0 ];
            var mapper = _serviceProvider.GetRequiredService( serviceType );

            applyConfiguration
                .MakeGenericMethod( entityType )
                .Invoke( modelBuilder, [ mapper ] );
        }
    }
}