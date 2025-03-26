namespace DotnetTemplate.Persistence.Helpers;

public class ValidationHelpers
{
    public static bool EnsurePropertyExists(Type entityType, string propertyName)
    {
        return entityType.GetProperty(propertyName) != null;
    }
}