using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dotnet.Domain.Abstraction;

namespace Dotnet.Domain.Entities;
using Microsoft.AspNetCore.Identity;

public class UsersEntity: IdentityUser<Guid>,IFullAuditable
{
    /// <summary>
    /// Primary key
    /// </summary>
    // [Key]
    public new Guid Id { get; set; }
    
    /// <summary>
    /// Tên của người dùng
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Họ của người dùng
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Họ và tên đầy đủ của người dùng
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// Ngày sinh
    /// </summary>
    public DateTime DateOfBirth { get; set; }
    
    /// <summary>
    /// Là giám đốc
    /// 0 - False, 1 - True
    /// </summary>
    public bool IsDirector { get; set; }
    
    /// <summary>
    /// Là trưởng phòng ban
    /// 0 - False, 1 - True
    /// </summary>
    public bool IsHeadOfDepartment { get; set; }
    
    /// <summary>
    /// Id người quản lý của user
    /// </summary>
    public  Guid ManagerId { get; set; }
    
    /// <summary>
    /// Id chức vụ của user
    /// </summary>
    public Guid PositionId { get; set; }
    
    public long OrderId { get;set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool IsDeleted { get; set; }
}