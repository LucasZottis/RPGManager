using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class DiceTypeEntityMapper : EntityBaseEntityMapper<DiceType>
{
    protected override void Map( EntityTypeBuilder<DiceType> builder )
    {
        builder.Property( p => p.Name ).HasMaxLength( MaxLength.ShortName );
        builder.Property( p => p.Sides );
    }
}