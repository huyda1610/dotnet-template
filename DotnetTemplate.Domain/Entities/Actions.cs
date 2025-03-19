namespace Dotnet.Domain.Entities;

public class Actions
{
    /// <summary>
    /// Khóa chính của đối tượng
    /// </summary>
    public Guid Id { get; set; }
    
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
    
    /// <summary>
    /// Xắp xếp theo thứ tự
    /// Tự động tăng +1 khi thêm mới đối tượng
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
    /// Người cập nhật gần nhất
    /// </summary>
    public string? ModifiedBy { get; set; }
    
    /// <summary>
    /// Thời gian cập nhật gần nhất
    /// </summary>
    public DateTime? ModifiedAt { get; set; }
    
    /// <summary>
    /// Người cập nhật gần nhất
    /// 1 - Đã xóa - không hiển thị trên UI, 0 - Dữ liệu vẫn còn hiệu lực
    /// </summary>
    public bool IsDeleted { get; set; }
}