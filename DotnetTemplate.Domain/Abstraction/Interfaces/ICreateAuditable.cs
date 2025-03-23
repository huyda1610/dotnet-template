namespace Dotnet.Domain.Abstraction.Interfaces;

public interface ICreateAuditable
{
    /// <summary>
    /// Email người tạo
    /// </summary>
    public string CreatedBy { get; set; }
    
    /// <summary>
    /// Thời gian tạo
    /// </summary>
    public DateTime CreatedAt { get; set; }
}