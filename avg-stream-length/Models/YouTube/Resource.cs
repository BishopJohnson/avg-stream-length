using System.Text.Json.Serialization;

namespace Models.YouTube;

internal abstract class Resource
{
    [JsonInclude]
    [JsonPropertyName("kind")]
    public Kind? Kind { get; private set; }
}