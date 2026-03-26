using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class LevelEntityMapper : GameSystemVersionBaseEntityMapper<Level>
{
    protected override void Map( EntityTypeBuilder<Level> builder )
    {
        builder.Property( e => e.LevelNumber ).IsRequired();
        builder.Property( e => e.ExperiencePoints ).IsRequired();
        builder.Property( e => e.ProficiencyBonus ).IsRequired();
    }
}
