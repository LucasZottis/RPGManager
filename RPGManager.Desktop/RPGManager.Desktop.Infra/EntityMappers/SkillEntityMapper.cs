using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class SkillEntityMapper : GameSystemVersionBaseEntityMapper<Skill>
{
    private readonly DnD521Seed _dnD521Seed;

    public SkillEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<Skill> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.BaseAbilityScoreId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description );

        builder.HasOne( e => e.BaseAbilityScore ).WithMany( e => e.SkillsBaseAbilityScore ).HasForeignKey( e => e.BaseAbilityScoreId );
        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.Skills ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetSkills() );
    }
}