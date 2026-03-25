using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Backgrounds;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class BackgroundEntityMapper : EntityBaseEntityMapper<Background>
{
    protected override void Map( EntityTypeBuilder<Background> builder )
    {
        builder.Property( p => p.GameSystemId );
        builder.Property( p => p.Name ).HasMaxLength( MaxLength.ShortName );
        builder.Property( p => p.Description ).IsRequired( false );
    }
}