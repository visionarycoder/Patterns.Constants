using System.Reflection;

namespace Example.Constants;

public class Constant
{

    public const string APPLICATION_NAME = "MyApp";
    public const string APPLICATION_VERSION = "1.0.0";
    public const string APPLICATION_DESCRIPTION = "MyApp is a sample application";

    public static readonly ICollection<string> All;

    static Constant()
    {

        // Step by step explanation
        var type = typeof(Constant);
        var fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
        var constantFields = fieldInfos.Where(fi => fi is { IsLiteral: true, IsInitOnly: false });
        var data = constantFields.Select(fi => fi.Name);
        All = data.ToList();

        // One-liner
        All = typeof(Constant)
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(fi => fi is { IsLiteral: true, IsInitOnly: false })
            .Select(fi => fi.Name)
            .ToList();

    }


}