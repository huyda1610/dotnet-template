using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

internal sealed class UserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.UserRoles);

        builder.HasKey(x => new { x.RoleId, x.UserId });
    }
}