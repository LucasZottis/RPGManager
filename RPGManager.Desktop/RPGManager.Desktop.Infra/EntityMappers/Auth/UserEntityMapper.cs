using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.Auth;

public class UserEntityMapper : EntityBaseEntityMapper<User>
{
    private readonly ICrypt _crypt;
    private readonly AuthSeed _authSeed;

    public UserEntityMapper( ICrypt crypt, AuthSeed authSeed )
    {
        _crypt = crypt;
        _authSeed = authSeed;
    }

    protected override void Map( EntityTypeBuilder<User> builder )
    {
        builder.Property( p => p.Name ).HasConversion(
            v => _crypt.Encrypt( v ),
            v => _crypt.Decrypt( v )
        ).HasMaxLength( MaxLength.LongName ).IsRequired();

        builder.Property( p => p.Email ).HasConversion(
            v => _crypt.Encrypt( v ),
            v => _crypt.Decrypt( v )
        ).HasMaxLength( MaxLength.Email ).IsRequired();

        builder.Property( p => p.PasswordHash ).HasMaxLength( MaxLength.Password ).IsRequired();
        builder.Property( p => p.CreatedAt ).HasDefaultValue( DateTime.Now ).IsRequired();

        builder.HasData( [ _authSeed.GetUserAdmin() ] );
    }
}