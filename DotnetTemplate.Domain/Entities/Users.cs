using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet.Domain.Entities;
using Microsoft.AspNetCore.Identity;

//Data Annotations
public class Users: IdentityUser<Guid>
{
    /// <summary>
    /// Primary key
    /// </summary>
    [Key]
    public new Guid Id { get; set; }
    
    /// <summary>
    /// Tên của người dùng
    /// </summary>
    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public required string FirstName { get; set; }
    
    /// <summary>
    /// Họ của người dùng
    /// </summary>
    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public required string LastName { get; set; }
    
    /// <summary>
    /// Họ và tên đầy đủ của người dùng
    /// </summary>
    [Required]
    [StringLength(200)]
    public required string FullName { get; set; }
    
    /// <summary>
    /// Ngày sinh
    /// </summary>
    [Required]
    public required DateTime DateOfBirth { get; set; }
    
    /// <summary>
    /// Là giám đốc
    /// 0 - False, 1 - True
    /// </summary>
    [Required]
    public required bool IsDirector { get; set; }
    
    /// <summary>
    /// Là trưởng phòng ban
    /// 0 - False, 1 - True
    /// </summary>
    [Required]
    public required bool IsHeadOfDepartment { get; set; }
    
    /// <summary>
    /// Id người quản lý của user
    /// </summary>
    [Required]
    public required Guid ManagerId { get; set; }
    
    /// <summary>
    /// Id chức vụ của user
    /// </summary>
    [Required]
    public required Guid PositionId { get; set; }
    
    /// <summary>
    /// Xắp xếp theo thứ tự
    /// Tự động tăng +1 khi thêm mới đối tượng
    /// </summary>
    [Required]
    public required long OrderId { get; set; }
    
    /// <summary>
    /// Email người tạo
    /// </summary>
    [Required]
    [StringLength(100)]
    public required string CreatedBy { get; set; }
    
    /// <summary>
    /// Thời gian tạo
    /// </summary>
    [Required]
    public required DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Người cập nhật gần nhất
    /// </summary>
    [StringLength(100)]
    public string? ModifiedBy { get; set; }
    
    /// <summary>
    /// Thời gian cập nhật gần nhất
    /// </summary>
    public DateTime? ModifiedAt { get; set; }
    
    /// <summary>
    /// Người cập nhật gần nhất
    /// 1 - Đã xóa - không hiển thị trên UI, 0 - Dữ liệu vẫn còn hiệu lực
    /// </summary>
    [Required]
    [StringLength(100)]
    public bool IsDeleted { get; set; }
}