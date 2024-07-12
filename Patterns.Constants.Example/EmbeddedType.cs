namespace Example.Constants;

public class EmbeddedType
{
    public Guid InstanceId { get; } = Guid.NewGuid();
    public DateTime Timestamp { get; } = DateTime.Now;
    public string Name { get; init; } = default!;
    public string Value { get; init; } = default!;
}