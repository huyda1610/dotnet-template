namespace Dotnet.Domain.Abstraction;

public abstract class BaseEntity<TKey>
{
    required public virtual TKey Id { get; set; }
    
    public bool IsTransient() => EqualityComparer<TKey>.Default.Equals(this.Id, default(TKey));
}