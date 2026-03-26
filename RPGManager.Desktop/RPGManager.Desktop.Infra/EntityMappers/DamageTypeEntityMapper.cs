using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class DamageTypeEntityMapper : GameSystemVersionBaseEntityMapper<DamageType>
{
    protected override void Map( EntityTypeBuilder<DamageType> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
    }
}