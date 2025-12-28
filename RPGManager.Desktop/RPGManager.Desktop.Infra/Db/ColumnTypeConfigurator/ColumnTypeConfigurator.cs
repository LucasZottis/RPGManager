using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RPGManager.Desktop.Infra.Db.Interfaces;

namespace RPGManager.Desktop.Infra.Db.ColumnTypeConfigurator;

public abstract class ColumnTypeConfigurator : IColumnTypeConfigurator, IModelFinalizingConvention
{
    protected IDictionary<Type, Action<IConventionProperty>> ColumnType;

    public ColumnTypeConfigurator()
    {
        ColumnType = GetTypes();
    }

    protected abstract IDictionary<Type, Action<IConventionProperty>> GetTypes();

    public void Configure( ModelConfigurationBuilder builder )
    {
        // registra ESTA PRÓPRIA CLASSE como convention
        builder.Conventions.Add( _ => this );
    }

    public void ProcessModelFinalizing( IConventionModelBuilder modelBuilder, IConventionContext<IConventionModelBuilder> context )
    {
        foreach ( var property in modelBuilder.Metadata
             .GetEntityTypes()
             .SelectMany( e => e.GetDeclaredProperties() ) )
        {
            if ( ColumnType.TryGetValue( property.ClrType, out var apply ) )
            {
                apply( property ); // <-- IMutableProperty FUNCIONA AQUI
            }
        }
    }
}