using System.Text.Json.Serialization;

namespace Common.Contracts;

public interface IMessage
{
    [JsonIgnore]
    public string MessageTypeName { get; }
}