using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class DamageTypeEntityMapper : EntityBaseEntityMapper<DamageType>
{
    protected override void Map( EntityTypeBuilder<DamageType> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.DamageTypes ).HasForeignKey( e => e.GameSystemId );
    }
}