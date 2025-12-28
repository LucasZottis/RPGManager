using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class SkillEntityMapper : EntityBaseEntityMapper<Skill>
{
    protected override void Map( EntityTypeBuilder<Skill> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.BaseAbilityScoreId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.Skills ).HasForeignKey( e => e.GameSystemId );
        builder.HasOne( e => e.BaseAbilityScore ).WithMany( e => e.Skills ).HasForeignKey( e => e.BaseAbilityScoreId );
    }
}