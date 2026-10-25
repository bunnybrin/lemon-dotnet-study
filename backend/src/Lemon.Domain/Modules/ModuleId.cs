namespace Lemon.Domain.Modules;

public record ModuleId
{
    private ModuleId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static ModuleId newModuleId() => new(Guid.NewGuid());

    public static ModuleId Empty() => new(Guid.Empty);
}