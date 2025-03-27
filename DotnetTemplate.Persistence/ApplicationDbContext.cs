using Dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetTemplate.Persistence;

public class ApplicationDbContext: DbContext
{
    DbSet<UsersEntity> Users { get; set; }
    DbSet<RolesEntity> Roles { get; set; }
    DbSet<PermissionsEntity> Permissions { get; set; }
    DbSet<FunctionsEntity> Functions { get; set; }
    DbSet<ActionInFunctionsEntity> ActionInFunctions { get; set; }
    DbSet<ActionsEntity> Actions { get; set; }
    DbSet<UserRolesEntity> UserRoles { get; set; }
    DbSet<RoleClaimsEntity> RoleClaims { get; set; }
    DbSet<UserClaimsEntity> UserClaims { get; set; }
    DbSet<UserLoginsEntity> UserLogins { get; set; }
    DbSet<UserTokensEntity> UserTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        
        base.OnModelCreating(builder);
        
        //Áp dụng cấu hình chung cho các Entity
        AuditableConfiguration(builder);
        
        
        //Thêm Query Filter tự động lọc dữ liệu xoá mềm
        ApplyGlobalQueryFilters(builder);
    }
    
    private static void AuditableConfiguration(ModelBuilder modelBuilder)
    {
        var entityTypes = modelBuilder.Model
            .GetEntityTypes()
            .Where(e => typeof(IAuditable).IsAssignableFrom(e.ClrType)
                        || typeof(IFullAuditable).IsAssignableFrom(e.ClrType))
            .Select(entityType => entityType.ClrType);

        foreach (var entityType in entityTypes)
        {
            var builder = modelBuilder.Entity(entityType);

            // Kiểm tra nếu entity thiếu thuộc tính bắt buộc thì throw exception
            EnsurePropertyExists(entityType, nameof(IAuditable.CreatedAt));
            EnsurePropertyExists(entityType, nameof(IAuditable.CreatedBy));
            EnsurePropertyExists(entityType, nameof(IAuditable.IsDeleted));
            EnsurePropertyExists(entityType, nameof(IAuditable.OrderId));

            // Áp dụng cấu hình cho thuộc tính audit chung
            builder.Property(nameof(IAuditable.CreatedAt))
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(nameof(IAuditable.CreatedBy))
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(nameof(IAuditable.IsDeleted))
                .HasDefaultValue(false);

            builder.Property(nameof(IAuditable.OrderId))
                .IsRequired()
                .ValueGeneratedOnAdd();

            // Nếu entity implement IFullAuditableEntity, áp dụng thêm cấu hình cho Modified
            if (typeof(IFullAuditable).IsAssignableFrom(entityType))
            {
                builder.Property(nameof(IFullAuditable.ModifiedAt))
                    .HasColumnType("datetime2")
                    .IsRequired(false);

                builder.Property(nameof(IFullAuditable.ModifiedBy))
                    .HasColumnType("VARCHAR(100)")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            }
        }
    }
    
    private static void EnsurePropertyExists(Type entityType, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(propertyName))
        {
            throw new ArgumentException(nameof(propertyName), "Property name cannot be null or empty.");
        }
        
        
        if ( entityType.GetProperty(propertyName) == null)
        {
            throw new ArgumentException(
                $"Property '{propertyName}' does not exist in the entity type '{entityType.Name}'.", 
                nameof(propertyName));
        }
    }

    private static void ApplyGlobalQueryFilters(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(IAuditable).IsAssignableFrom(entityType.ClrType))
            {
                CreateQueryFilter<IAuditable>(modelBuilder);
            }
        }
    }

    private static void CreateQueryFilter<TEntity>(ModelBuilder modelBuilder) where TEntity : class, IAuditable
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(e => e!.IsDeleted);
    }
    
}

