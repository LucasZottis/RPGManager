using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.AuthEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.Auth;

public class UserRoleEntityMapper : IEntityTypeConfiguration<UserRole>
{
    public void Configure( EntityTypeBuilder<UserRole> builder )
    {
        builder.Property( e => e.UserId ).IsRequired();
        builder.Property( e => e.RoleId ).IsRequired();

        builder.HasKey( e => new { e.UserId, e.RoleId } );

        builder.HasOne( e => e.User ).WithMany( e => e.Roles ).HasForeignKey( e => e.UserId );
        builder.HasOne( e => e.Role ).WithMany( e => e.Users ).HasForeignKey( e => e.RoleId );
    }
}