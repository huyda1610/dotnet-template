using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class UsersConfiguration:IEntityTypeConfiguration<UsersEntity>
{
    public void Configure(EntityTypeBuilder<UsersEntity> builder)
    {
        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()");
        builder.Property(c => c.FirstName).HasColumnType("nvarchar(100)").IsRequired();
    }
}