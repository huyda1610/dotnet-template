namespace Dotnet.Domain.Abstraction.Interfaces;

public interface ISortOrder
{
    /// <summary>
    /// Xắp xếp theo thứ tự
    /// Tự động tăng +1 khi thêm mới đối tượng
    /// </summary>
    public long OrderId { get;set; }
    
}