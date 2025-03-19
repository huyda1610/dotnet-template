namespace Dotnet.Domain.Entities;

public class Functions
{
    /// <summary>
    /// Khóa chính của đối tượng
    /// </summary>
    public Guid Id { get; set; }
    
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