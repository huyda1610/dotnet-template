using DotnetTemplate.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;

// private static void AuditableConfiguration(ModelBuilder modelBuilder)
// {
//     var entityTypes = modelBuilder.Model
//         .GetEntityTypes()
//         .Where(e => typeof(IAuditable).IsAssignableFrom(e.ClrType)
//                     || typeof(IFullAuditable).IsAssignableFrom(e.ClrType))
//         .Select(entityType => entityType.ClrType);
//
//     foreach (var entityType in entityTypes)
//     {
//         var builder = modelBuilder.Entity(entityType);
//
//         // Kiểm tra nếu entity thiếu thuộc tính bắt buộc thì throw exception
//         ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.CreatedAt));
//         ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.CreatedBy));
//         ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.IsDeleted));
//         ValidationHelpers.EnsurePropertyExists(entityType, nameof(IAuditable.OrderId));
//
//         // Áp dụng cấu hình cho thuộc tính audit chung
//         builder.Property(nameof(IAuditable.CreatedAt))
//             .HasColumnType("datetime2")
//             .IsRequired();
//
//         builder.Property(nameof(IAuditable.CreatedBy))
//             .HasColumnType("VARCHAR(100)")
//             .HasMaxLength(100)
//             .IsUnicode(false);
//
//         builder.Property(nameof(IAuditable.IsDeleted))
//             .HasDefaultValue(false);
//
//         builder.Property(nameof(IAuditable.OrderId))
//             .IsRequired()
//             .ValueGeneratedOnAdd();
//
//         // Nếu entity implement IFullAuditableEntity, áp dụng thêm cấu hình cho Modified
//         if (typeof(IFullAuditable).IsAssignableFrom(entityType))
//         {
//             builder.Property(nameof(IFullAuditable.ModifiedAt))
//                 .HasColumnType("datetime2")
//                 .IsRequired(false);
//
//             builder.Property(nameof(IFullAuditable.ModifiedBy))
//                 .HasColumnType("VARCHAR(100)")
//                 .HasMaxLength(100)
//                 .IsUnicode(false);
//         }
//     }
// }