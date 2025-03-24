using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class UsersConfiguration: IEntityTypeConfiguration<UsersEntity>
{
    public void Configure(EntityTypeBuilder<UsersEntity> builder)
    {
        
        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").HasColumnType("uniqueidentifier");
        builder.Property(c => c.FirstName).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(c => c.LastName).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(c => c.FullName).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(c => c.DateOfBirth).HasColumnType("datetime2").IsRequired();
        builder.Property(c => c.IsDirector).HasColumnType("bit").IsRequired();
        builder.Property(c => c.IsHeadOfDepartment).HasColumnType("bit").IsRequired();
        builder.Property(c => c.ManagerId).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(c => c.PositionId).HasColumnType("uniqueidentifier").IsRequired();
        
        builder.Property(c => c.OrderId).HasColumnType("long").IsRequired();
        builder.Property(c => c.CreatedBy).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(c => c.CreatedAt).HasColumnType("datetime2").IsRequired();
        builder.Property(c => c.ModifiedBy).HasColumnType("nvarchar").IsRequired(false);
        builder.Property(c => c.ModifiedAt).HasColumnType("datetime2").IsRequired(false);
        builder.Property(c => c.IsDeleted).HasColumnType("bit").IsRequired();
    }
}