using Common.Contracts;

namespace Common.Messages;

public abstract class BaseMessage : IMessage
{
    public virtual string MessageTypeName => this.GetType().Name;
}