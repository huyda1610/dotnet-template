using Dotnet.Domain.Abstraction;

namespace Dotnet.Domain.Entities;

public class FunctionsEntity:FullAuditableEntity<Guid>
{
    /// <summary>
    /// Mã chức năng
    /// </summary>
    public string Code { get; set; }
    
    /// <summary>
    /// Tên chức năng
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Url liên kết đến chức năng
    /// </summary>
    public string Url { get; set; }
    
    /// <summary>
    /// MId parrent của chức năng
    /// </summary>
    public Guid ParrentId { get; set; }
    
    /// <summary>
    /// Chỗi string html/css
    /// </summary>
    public Guid CssClass { get; set; }

    /// <summary>
    /// Trạng thái kích hoạt
    /// </summary>
    public bool IsActived { get; set; }
}