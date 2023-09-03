using System.Text.Json.Serialization;

namespace Models.YouTube;

internal class VideoSnippet
{
    [JsonInclude]
    [JsonPropertyName("publishedAt")]
    public DateTime? PublishedAt { get; private set; }

    [JsonInclude]
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; private set; }

    [JsonInclude]
    [JsonPropertyName("title")]
    public string? Title { get; private set; }

    [JsonInclude]
    [JsonPropertyName("description")]
    public string? Description { get; private set; }

    [JsonInclude]
    [JsonPropertyName("thumbnails")]
    public Dictionary<string, VideoSnippetThumbnail>? Thumbnails { get; private set; }
}