namespace Dotnet.Domain.Abstraction.Interfaces;

public interface ISoftDelete
{
    /// <summary>
    /// Soft delete
    /// 1 - Đã xóa - không hiển thị trên UI, 0 - Dữ liệu vẫn còn hiệu lực
    /// </summary>
    public bool IsDeleted { get; set; }
}