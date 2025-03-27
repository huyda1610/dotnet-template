using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations;

public class PermissionsConfiguration : IEntityTypeConfiguration<PermissionsEntity>
{
    public void Configure(EntityTypeBuilder<PermissionsEntity> builder)
    {
        builder.ToTable(DatabaseConst.TableNames.Permissions);

        builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").HasColumnType("uniqueidentifier");
        builder.Property(c => c.RoleId).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(c => c.FunctionId).HasColumnType("uniqueidentifier").IsRequired();
        builder.Property(c => c.ActionId).HasColumnType("uniqueidentifier").IsRequired();

        builder.HasOne<RolesEntity>() 
            .WithMany() 
            .HasForeignKey(p => p.RoleId) 
            .IsRequired();
        
        builder.HasOne<FunctionsEntity>() 
            .WithMany() 
            .HasForeignKey(p => p.FunctionId) 
            .IsRequired();
        
        builder.HasOne<ActionsEntity>() 
            .WithMany() 
            .HasForeignKey(p => p.ActionId) 
            .IsRequired();
    }
}