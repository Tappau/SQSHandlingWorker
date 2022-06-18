namespace Common.Messages;

public class CustomerCreated : BaseMessage
{
    public Guid Id { get; init; }

    public string? FirstName { get; init; }

    public string? LastName { get; init; }
}