using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class ClassEntityMapper : EntityBaseEntityMapper<Class>
{
    protected override void Map( EntityTypeBuilder<Class> builder )
    {
        builder.Property( p => p.GameSystemId );
        builder.Property( p => p.Name ).HasMaxLength( MaxLength.ShortName );
    }
}