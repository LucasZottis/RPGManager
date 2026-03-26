using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class SizeEntityMapper : GameSystemVersionBaseEntityMapper<Size>
{
    protected override void Map( EntityTypeBuilder<Size> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.MinHeight ).IsRequired();
        builder.Property( e => e.MaxHeight ).IsRequired();
    }
}
