using System.Diagnostics.CodeAnalysis;

namespace Common.Messages;

[ExcludeFromCodeCoverage]
public class CustomerDeleted : BaseMessage
{
    public Guid Id { get; init; }
}