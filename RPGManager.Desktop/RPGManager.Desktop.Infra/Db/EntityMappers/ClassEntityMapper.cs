using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class ClassEntityMapper : EntityBaseEntityMapper<Class>
{
    protected override void Map( EntityTypeBuilder<Class> builder )
    {
        builder.Property( p => p.GameSystemId );
        builder.Property( p => p.Name ).HasMaxLength( MaxLength.ShortName );
    }
}