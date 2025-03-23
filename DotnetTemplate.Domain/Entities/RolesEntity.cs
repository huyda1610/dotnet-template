using Microsoft.AspNetCore.Identity;

namespace Dotnet.Domain.Entities;

public class RolesEntity: IdentityRole<Guid>,IFullAuditable
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
    
    public long OrderId { get;set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool IsDeleted { get; set; }
}