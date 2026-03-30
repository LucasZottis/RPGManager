using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class ShieldArmorEntityMapper : IEntityTypeConfiguration<ShieldArmor>
{
    public void Configure( EntityTypeBuilder<ShieldArmor> builder )
    {
        builder.ToTable( nameof( ShieldArmor ).ToLower(), $"pk_{nameof( ShieldArmor ).ToLower()}" ); // tabela separada de Item

        builder.Property( e => e.ArmorClassBonus ).IsRequired();

        builder.HasOne<Armor>()
           .WithOne( e => e.Shield ) // precisa adicionar Tool em Item
           .HasForeignKey<ShieldArmor>( e => e.Id ); // FK é o próprio Id — 1:1
    }
}