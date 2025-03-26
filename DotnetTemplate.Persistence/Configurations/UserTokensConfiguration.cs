using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class UserTokensConfiguration: IEntityTypeConfiguration<IdentityUserToken<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserToken<Guid>> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.UserTokens);

        builder.HasKey(x => x.UserId);
    }
}