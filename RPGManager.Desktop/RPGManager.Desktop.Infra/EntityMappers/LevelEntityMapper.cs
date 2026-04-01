using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class LevelEntityMapper : GameSystemVersionBaseEntityMapper<Level>
{
    private readonly DnD521Seed _dnD521Seed;

    public LevelEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<Level> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.LevelNumber ).IsRequired();
        builder.Property( e => e.ExperiencePoints ).IsRequired();
        builder.Property( e => e.ProficiencyBonus ).IsRequired();

        builder.HasMany( e => e.ClassesLevels ).WithOne( cl => cl.Level ).HasForeignKey( cl => cl.LevelId );
        builder.HasData( _dnD521Seed.GetLevels() );
    }
}