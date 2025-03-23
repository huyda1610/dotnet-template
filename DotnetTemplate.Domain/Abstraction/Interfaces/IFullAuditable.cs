
using Dotnet.Domain.Abstraction.Interfaces;

public interface IFullAuditable: ISortOrder, ISoftDelete, ICreateAuditable, IModifyAuditable
{
    public long OrderId { get;set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool IsDeleted { get; set; }
}