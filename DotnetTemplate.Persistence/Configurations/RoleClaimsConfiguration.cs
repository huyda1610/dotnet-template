using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal sealed class RoleClaimsConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityRoleClaim<Guid>> builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        builder.ToTable(DatabaseConst.TableNames.RoleClaims);

        builder.HasKey(x => x.RoleId);

        builder.Property(x => x.ClaimType)
            .HasColumnType("VARCHAR(4000)")
            .HasDefaultValue(string.Empty);

        builder.Property(x => x.ClaimValue)
            .HasColumnType("VARCHAR(4000)")
            .HasDefaultValue(string.Empty);
    }
}