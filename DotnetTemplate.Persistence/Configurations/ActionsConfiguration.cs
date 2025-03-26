using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class ActionsConfiguration : IEntityTypeConfiguration<ActionsEntity>
{
    public void Configure(EntityTypeBuilder<ActionsEntity> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.ActionInFunctions);

        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").HasColumnType("uniqueidentifier");
        builder.Property(c => c.Code).HasColumnType("varchar(200)");
        builder.Property(c => c.Name).HasColumnType("nvarchar(200)");
        builder.Property(c => c.IsActived).HasColumnType("bit");
    }
}