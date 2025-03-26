using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class FunctionsConfiguration : IEntityTypeConfiguration<FunctionsEntity>
{
    public void Configure(EntityTypeBuilder<FunctionsEntity> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.Functions);

        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").HasColumnType("uniqueidentifier");
        builder.Property(c => c.Code).HasColumnType("varchar(200)").IsRequired();
        builder.Property(c => c.Name).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(c => c.Url).HasColumnType("nvarchar(4000)").IsRequired();
        builder.Property(c => c.ParrentId).HasColumnType("uniqueidentifier");
        builder.Property(c => c.CssClass).HasColumnType("nvarchar(4000)");
        builder.Property(c => c.IsActived).HasColumnType("bit");
    }
}