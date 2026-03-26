using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class ArmorEntityMapper : IEntityTypeConfiguration<Armor>
{
    public void Configure( EntityTypeBuilder<Armor> builder )
    {
        builder.Property( e => e.ArmorCategoryId ).IsRequired();
        builder.Property( e => e.RequiredAbilityScoreId );
        builder.Property( e => e.RequiredAbilityScoreMinimum ).IsRequired();
        builder.Property( e => e.DisadvantageOnStealth ).IsRequired();

        builder.HasOne( e => e.ArmorCategory ).WithMany( e => e.Armors ).HasForeignKey( e => e.ArmorCategoryId );
        builder.HasOne( e => e.RequiredAbilityScore ).WithMany( e => e.ArmorsRequiredAbilityScoreId ).HasForeignKey( e => e.RequiredAbilityScoreId );
    }
}
