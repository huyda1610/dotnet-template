using Dotnet.Domain.Abstraction;

namespace Dotnet.Domain.Entities;

public class ActionInFunctionsEntity:FullAuditableEntity
{
    /// <summary>
    /// Khóa chính của đối tượng
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Khóa ngoại liên kết đến bảng Actions
    /// </summary>
    public Guid ActionId { get; set; }
    
    /// <summary>
    /// Khóa ngoại liên kết đến bảng Functions
    /// </summary>
    public Guid FunctionId { get; set; }
}