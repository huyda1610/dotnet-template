using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class RolesConfiguration: IEntityTypeConfiguration<RolesEntity>
{
    public void Configure(EntityTypeBuilder<RolesEntity> builder)
    {
        
        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").HasColumnType("uniqueidentifier");
        builder.Property(c => c.Description).HasColumnType("nvarchar").IsRequired();
        builder.Property(c => c.RoleCode).HasColumnType("nvarchar").IsRequired();
        
        builder.Property(c => c.OrderId).HasColumnType("long").IsRequired();
        builder.Property(c => c.CreatedBy).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(c => c.CreatedAt).HasColumnType("datetime2").IsRequired();
        builder.Property(c => c.ModifiedBy).HasColumnType("nvarchar").IsRequired(false);
        builder.Property(c => c.ModifiedAt).HasColumnType("datetime2").IsRequired(false);
        builder.Property(c => c.IsDeleted).HasColumnType("bit").IsRequired();
    }
}