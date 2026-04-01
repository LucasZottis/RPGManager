using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceEntityMapper : GameSystemVersionBaseEntityMapper<Race>
{
    protected override void Map( EntityTypeBuilder<Race> builder )
    {
        builder.Property( e => e.ParentRaceId ).IsRequired( false );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired( false );
        builder.Property( e => e.Speed ).IsRequired();
        builder.Property( e => e.CreatureType ).IsRequired().HasMaxLength( MaxLength.MediumName );

        builder.HasOne( e => e.ParentRace )
            .WithMany( e => e.SubRaces )
            .HasForeignKey( e => e.ParentRaceId );
    }
}