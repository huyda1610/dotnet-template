using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class RolesConfiguration: IEntityTypeConfiguration<RolesEntity>
{
    public void Configure(EntityTypeBuilder<RolesEntity> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.Roles);
        
        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").HasColumnType("uniqueidentifier");
        builder.Property(c => c.Description).HasColumnType("nvarchar").IsRequired();
        builder.Property(c => c.RoleCode).HasColumnType("nvarchar").IsRequired();
    }
}