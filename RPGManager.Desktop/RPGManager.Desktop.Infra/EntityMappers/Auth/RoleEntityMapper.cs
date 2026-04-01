using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.Auth;

public class RoleEntityMapper : EntityBaseEntityMapper<Role>
{
    private readonly AuthSeed _authSeed;

    public RoleEntityMapper( AuthSeed authSeed )
    {
        _authSeed = authSeed;
    }

    protected override void Map( EntityTypeBuilder<Role> builder )
    {
        builder.Property( e => e.Name ).HasMaxLength( MaxLength.ShortName ).IsRequired();
        builder.Property( e => e.Description ).IsRequired( false );

        builder.HasData( _authSeed.GetRoles() );
    }
}