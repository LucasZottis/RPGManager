using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.Auth;

public class RoleEntityMapper : EntityBaseEntityMapper<Role>
{
    protected override void Map( EntityTypeBuilder<Role> builder )
    {
        builder.Property( e => e.Name ).HasMaxLength( MaxLength.ShortName ).IsRequired();
        builder.Property( e => e.Description ).IsRequired( false );

        builder.HasData( [
            new Role {
                Id = Guid.NewGuid(),
                Name = Roles.Admin,
                Description = "Role with all permissions.",
            },

            new Role {
                Id = Guid.NewGuid(),
                Name = Roles.Admin,
                Description = "Role with limited permissions.",
            },
        ] );
    }
}