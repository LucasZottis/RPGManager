using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RPGManager.Desktop.Infra.Db.Interfaces;

namespace RPGManager.Desktop.Infra.Db.NameConvetion;

public abstract class NameConvetionConfigurator : INameConvetionConfigurator
{
    public abstract void Configure( IConventionModelBuilder modelBuilder );

    public void ProcessModelFinalizing( IConventionModelBuilder modelBuilder, IConventionContext<IConventionModelBuilder> context )
    {
        Configure( modelBuilder );
    }
}