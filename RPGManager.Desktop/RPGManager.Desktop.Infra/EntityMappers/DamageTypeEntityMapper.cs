using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class DamageTypeEntityMapper : GameSystemVersionBaseEntityMapper<DamageType>
{
    private readonly DnD521Seed _dnD521Seed;
    public DamageTypeEntityMapper(DnD521Seed dnD521Seed)
    {
        _dnD521Seed = dnD521Seed;
    }
    protected override void Map( EntityTypeBuilder<DamageType> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.DamageTypes ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetDamageTypes() );
    }
}