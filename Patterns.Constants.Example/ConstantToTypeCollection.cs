using System.Reflection;

namespace Example.Constants;

public static class ConstantToTypeCollection
{

    public static readonly List<EmbeddedType> All;

    public const string NAME = "My Name";
    public const string VERSION = "1.0.0";
    public const string DESCRIPTION = "My Description";

    static ConstantToTypeCollection()
    {

        // Step by step explanation
        var type = typeof(ConstantToDictionary);
        var fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
        var constantFields = fieldInfos.Where(fi => fi is { IsLiteral: true, IsInitOnly: false });
        var embeddedTypes = constantFields.Select(fi => new EmbeddedType
        {
            Name = fi.Name,
            Value = fi.GetValue(null)?.ToString() ?? string.Empty,
        });
        All = embeddedTypes.ToList();

        // One-liner
        All = typeof(ConstantToDictionary)
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(fi => fi is { IsLiteral: true, IsInitOnly: false })
            .Select(fi => new EmbeddedType
            {
                Name = fi.Name,
                Value = fi.GetValue(null)?.ToString() ?? string.Empty,
            })
            .ToList();
    }

}