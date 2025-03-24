using Dotnet.Domain.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTemplate.Persistence.Configurations.Common;

public abstract class FullAuditableEntityConfiguration<TEntity, TKey> 
    : IEntityTypeConfiguration<TEntity> 
    where TEntity : FullAuditableEntity<TKey>
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(e => e.CreatedBy).HasMaxLength(50);
    }
}