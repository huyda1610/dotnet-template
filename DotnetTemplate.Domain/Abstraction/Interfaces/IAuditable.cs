
using Dotnet.Domain.Abstraction.Interfaces;

public interface IAuditable: ISortOrder, ISoftDelete, ICreateAuditable
{
}