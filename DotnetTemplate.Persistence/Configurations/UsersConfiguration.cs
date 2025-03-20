using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class UsersConfiguration:IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()");
        builder.Property(c => c.FirstName).HasColumnType("nvarchar(100)").IsRequired();
    }
}