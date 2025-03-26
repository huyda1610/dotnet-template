using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

internal sealed class UserLoginsConfiguration:IEntityTypeConfiguration<IdentityUserLogin<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserLogin<Guid>> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.UserLogins);

        builder.HasKey(x => x.UserId);
    }
}