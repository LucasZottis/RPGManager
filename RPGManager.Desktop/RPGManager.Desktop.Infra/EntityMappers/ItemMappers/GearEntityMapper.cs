using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class GearEntityMapper : IEntityTypeConfiguration<Gear>
{
    public void Configure( EntityTypeBuilder<Gear> builder )
    {
        builder.ToTable( nameof( Gear ).ToLower(), $"pk_{nameof( Gear ).ToLower()}" ); // tabela separada de Item

        builder.HasOne<Item>()
           .WithOne( e => e.Gear ) // precisa adicionar Tool em Item
           .HasForeignKey<Gear>( e => e.Id ); // FK é o próprio Id — 1:1
    }
}
