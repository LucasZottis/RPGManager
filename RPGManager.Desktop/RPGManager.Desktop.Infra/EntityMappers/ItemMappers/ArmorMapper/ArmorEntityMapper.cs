using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class ArmorEntityMapper : IEntityTypeConfiguration<Armor>
{
    //private readonly DnD521Seed _seed;

    //public ArmorEntityMapper( DnD521Seed dnD521Seed )
    //{
    //    _seed = dnD521Seed;
    //}

    public void Configure( EntityTypeBuilder<Armor> builder )
    {
        builder.Property( e => e.ArmorCategoryId ).IsRequired();
        builder.Property( e => e.RequiredAbilityScoreId );
        builder.Property( e => e.RequiredAbilityScoreMinimum ).IsRequired();
        builder.Property( e => e.DisadvantageOnStealth ).IsRequired();

        builder.HasOne( e => e.ArmorCategory ).WithMany( e => e.Armors ).HasForeignKey( e => e.ArmorCategoryId );
        builder.HasOne( e => e.RequiredAbilityScore ).WithMany( e => e.ArmorsRequiredAbilityScoreId ).HasForeignKey( e => e.RequiredAbilityScoreId );
        builder.HasOne<Item>().WithOne( e => e.Armor ).HasForeignKey<Armor>( e => e.Id ); // FK é o próprio Id — 1:1

        //builder.HasData( _seed.GetAr )
    }
}
