using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace RPGManager.Desktop.Infra.Db.Interfaces;

public interface INameConvetionConfigurator : IModelFinalizingConvention
{
    void Configure( IConventionModelBuilder modelBuilder );
}