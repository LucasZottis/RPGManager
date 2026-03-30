using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.AuthEntities;
using RPGManager.Desktop.Domain.Interfaces;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.Auth;

public class UserEntityMapper : EntityBaseEntityMapper<User>
{
    private readonly ICrypt _crypt;

    public UserEntityMapper( ICrypt crypt )
    {
        _crypt = crypt;
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

        builder.HasData( [
            new User {
                Id = Guid.NewGuid(),
                Name = "Lucas Zottis",
                Email = "zottis.lucas@hotmail.com",
                PasswordHash = _crypt.Hash( "Foxtrot@153" ),
                CreatedAt = DateTime.Now,
            }
        ] );
    }
}