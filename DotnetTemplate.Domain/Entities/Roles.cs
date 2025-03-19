using Microsoft.AspNetCore.Identity;

namespace Dotnet.Domain.Entities;

public class Roles: IdentityRole<Guid>
{
    // /// <summary>
    // /// Primary key
    // /// </summary>
    // public new Guid Id { get; set; }
    
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// RoleCode
    /// </summary>
    public string RoleCode { get; set; }
    
    /// <summary>
    /// Xắp xếp theo thứ tự
    /// </summary>
    public long OrderId { get; set; }
    
    /// <summary>
    /// Email người tạo
    /// </summary>
    public string CreatedBy { get; set; }
    
    /// <summary>
    /// Thời gian tạo
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Người cập nhật
    /// </summary>
    public string? ModifiedBy { get; set; }
    
    /// <summary>
    /// Thời gian cập nhật
    /// </summary>
    public DateTime? ModifiedAt { get; set; }
    
    /// <summary>
    /// Soft delete
    /// 1 - Đã xóa - không hiển thị trên UI, 0 - Dữ liệu vẫn còn hiệu lực
    /// </summary>
    public bool IsDeleted { get; set; }
}