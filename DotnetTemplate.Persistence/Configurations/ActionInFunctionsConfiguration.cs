using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class ActionInFunctionsConfiguration : IEntityTypeConfiguration<ActionInFunctionsEntity>
{
    public void Configure(EntityTypeBuilder<ActionInFunctionsEntity> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.ActionInFunctions);

        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").HasColumnType("uniqueidentifier");
        builder.Property(c => c.ActionId).HasColumnType("uniqueidentifier");
        builder.Property(c => c.FunctionId).HasColumnType("uniqueidentifier");
        
        builder.HasOne<ActionsEntity>() 
            .WithMany() 
            .HasForeignKey(p => p.ActionId) 
            .IsRequired();
        
        builder.HasOne<FunctionsEntity>() 
            .WithMany() 
            .HasForeignKey(p => p.FunctionId) 
            .IsRequired();
    }
}