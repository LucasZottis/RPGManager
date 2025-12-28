using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class AlignmentEntityMapper : EntityBaseEntityMapper<Alignment>
{
    protected override void Map( EntityTypeBuilder<Alignment> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired();

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.Alignments ).HasForeignKey( e => e.GameSystemId );
    }
}