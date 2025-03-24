using Dotnet.Domain.Abstraction;

namespace Dotnet.Domain.Entities;

public class ActionsEntity:FullAuditableEntity<Guid>
{
    /// <summary>
    /// Mã của hành động
    /// </summary>
    public string Code { get; set; }
    
    /// <summary>
    /// Tên hành động
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Trạng thái kích hoạt
    /// Trạng thái kích hoạt. 1-True-Kích hoạt, 2-False-Không được kích hoạt
    /// </summary>
    public bool IsActived { get; set; }
}