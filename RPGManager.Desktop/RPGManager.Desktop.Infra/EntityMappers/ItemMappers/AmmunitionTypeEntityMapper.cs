using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class AmmunitionTypeEntityMapper : IEntityTypeConfiguration<AmmunitionType>
{
    public void Configure( EntityTypeBuilder<AmmunitionType> builder )
    {
        builder.Property( e => e.Amount ).IsRequired();
        builder.Property( e => e.Storage ).IsRequired().HasMaxLength( MaxLength.MediumName );

        builder.ToTable( nameof( AmmunitionType ).ToLower(), $"pk_{nameof( AmmunitionType ).ToLower()}" ); // tabela separada de Item

        builder.HasOne<Item>()
           .WithOne( e => e.AmmunitionType ) // precisa adicionar Tool em Item
           .HasForeignKey<AmmunitionType>( e => e.Id ); // FK é o próprio Id — 1:1
    }
}
