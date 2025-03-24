using Dotnet.Domain.Abstraction;

namespace Dotnet.Domain.Entities;

public class PermissionsEntity: FullAuditableEntity<Guid>
{
    /// <summary>
    /// Khóa ngoại liên kết đến bảng Roles
    /// </summary>
    public Guid RoleId { get; set; }
    
    /// <summary>
    /// Khóa ngoại liên kết đến bảng Functions
    /// </summary>
    public Guid FunctionId { get; set; }
    
    /// <summary>
    /// Khóa ngoại liên kết đến bảng Actions
    /// </summary>
    public Guid ActionId { get; set; }
}