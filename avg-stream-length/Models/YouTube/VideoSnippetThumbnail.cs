using System.Text.Json.Serialization;

namespace Models.YouTube;

public class VideoSnippetThumbnail
{
    [JsonInclude]
    [JsonPropertyName("url")]
    public string? Url { get; private set; }

    [JsonInclude]
    [JsonPropertyName("width")]
    public uint? Width { get; private set; }

    [JsonInclude]
    [JsonPropertyName("height")]
    public uint? Height { get; private set; }
}