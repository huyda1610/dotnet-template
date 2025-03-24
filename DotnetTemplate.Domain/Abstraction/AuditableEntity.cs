using Dotnet.Domain.Abstraction.Interfaces;

namespace Dotnet.Domain.Abstraction;

public abstract class AuditableEntity<TKey> : BaseEntity<TKey>, IAuditable
{
    public long OrderId { get;set; }
    
    public string CreatedBy { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public bool IsDeleted { get; set; }

}