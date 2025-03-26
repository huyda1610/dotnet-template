using Dotnet.Domain.Entities;
using DotnetTemplate.Persistence.Helpers;
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
            ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.CreatedAt));
            ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.CreatedBy));
            ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.IsDeleted));
            ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.OrderId));

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
}

