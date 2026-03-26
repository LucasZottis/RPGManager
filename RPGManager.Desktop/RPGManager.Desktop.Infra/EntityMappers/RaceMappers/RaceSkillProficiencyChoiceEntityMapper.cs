using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceSkillProficiencyChoiceEntityMapper : EntityChoiceBaseEntityMapper<RaceSkillProficiencyChoice>
{
    protected override void Map( EntityTypeBuilder<RaceSkillProficiencyChoice> builder )
    {
        builder.Property( e => e.RaceId ).IsRequired();

        builder.HasOne( e => e.Race ).WithOne( e => e.SkillProficiencyChoice ).HasForeignKey<RaceSkillProficiencyChoice>( e => e.RaceId );
    }
}
