using System.Text.Json.Serialization;

namespace Models.YouTube;

internal class VideoContentDetails
{
    [JsonInclude]
    [JsonPropertyName("duration")]
    public string? Duration { get; private set; }
}