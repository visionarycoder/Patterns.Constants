namespace Example.Constants;

public static class EmbeddedTypeExtension
{

    public static string ToDisplayString(this EmbeddedType embeddedType)
    {
        return $"{nameof(embeddedType.InstanceId)}:{embeddedType.InstanceId}; " +
               $"{nameof(embeddedType.Timestamp)}:{embeddedType.Timestamp:G}; " +
               $"{nameof(embeddedType.Name)}:{embeddedType.Name}; " +
               $"{nameof(embeddedType.Value)}{embeddedType.Value};";
    }

}