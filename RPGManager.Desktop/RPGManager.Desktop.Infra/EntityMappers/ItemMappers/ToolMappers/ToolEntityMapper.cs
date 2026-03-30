using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ToolMappers;

public class ToolEntityMapper : IEntityTypeConfiguration<Tool>
{
    public void Configure( EntityTypeBuilder<Tool> builder )
    {
        builder.ToTable( nameof( Tool ).ToLower(), $"pk_{nameof( Tool ).ToLower()}" ); // tabela separada de Item

        builder.Property( e => e.CheckAbilityScoreId );

        builder.HasOne<Item>()
               .WithOne( e => e.Tool ) // precisa adicionar Tool em Item
               .HasForeignKey<Tool>( e => e.Id ); // FK é o próprio Id — 1:1

        builder.HasOne( e => e.Ability )
               .WithMany()
               .HasForeignKey( e => e.CheckAbilityScoreId );
    }
}
