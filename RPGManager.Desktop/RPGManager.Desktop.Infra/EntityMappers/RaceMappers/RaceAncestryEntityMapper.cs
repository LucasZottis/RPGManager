using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceAncestryEntityMapper : EntityBaseEntityMapper<RaceAncestry>
{
    protected override void Map( EntityTypeBuilder<RaceAncestry> builder )
    {
        builder.Property( e => e.RaceId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.MediumName );
        builder.Property( e => e.Description );

        builder.HasOne( e => e.Race ).WithMany( e => e.Ancestries ).HasForeignKey( e => e.RaceId );
    }
}
