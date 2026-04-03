using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponPropertyEntityMapper : GameSystemVersionBaseEntityMapper<WeaponProperty>
{
    private readonly DnD521Seed _dnD521Seed;

    public WeaponPropertyEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<WeaponProperty> builder )
    {
        builder.Property( e => e.AlternativeAbilityScoreId ).IsRequired( false );

        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired( false );
        builder.Property( e => e.HasAlternativeDiceTypeDamage ).IsRequired().HasDefaultValue( false );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.WeaponProperties ).HasForeignKey( e => e.GameSystemVersionId );
        builder.HasOne( e => e.AlternativeAbilityScore ).WithMany( e => e.AlternativeAbilityScoreForWeaponProperties ).HasForeignKey( e => e.AlternativeAbilityScoreId );

        builder.HasData( _dnD521Seed.GetWeaponProperties() );
    }
}