using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

internal sealed class UserClaimsConfiguration:IEntityTypeConfiguration<IdentityUserClaim<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserClaim<Guid>> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.UserClaims);

        builder.HasKey(x => x.UserId);

        builder.Property(x => x.ClaimType)
            .HasColumnType("VARCHAR(4000)")
            .HasDefaultValue(string.Empty);

        builder.Property(x => x.ClaimValue)
            .HasColumnType("VARCHAR(4000)")
            .HasDefaultValue(string.Empty);
    }
}