using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class DiceTypeEntityMapper : EntityBaseEntityMapper<DiceType>
{
    protected override void Map( EntityTypeBuilder<DiceType> builder )
    {
        builder.Property( p => p.Name ).HasMaxLength( MaxLength.ShortName );
        builder.Property( p => p.Sides );
    }
}