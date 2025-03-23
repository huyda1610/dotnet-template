namespace Dotnet.Domain.Abstraction.Interfaces;

public interface IModifyAuditable
{
    /// <summary>
    /// Người cập nhật gần nhất
    /// </summary>
    public string? ModifiedBy { get; set; }
    
    /// <summary>
    /// Thời gian cập nhật gần nhất
    /// </summary>
    public DateTime? ModifiedAt { get; set; }
}