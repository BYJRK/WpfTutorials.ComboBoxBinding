namespace WpfIdeas;

[AttributeUsage(AttributeTargets.Field)]
class LocalizationAttribute : Attribute
{
    public required string ResourceName { get; init; }
    public required Type ResourceType { get; init; }
}