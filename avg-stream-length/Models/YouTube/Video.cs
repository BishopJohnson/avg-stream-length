using System.Text.Json.Serialization;

namespace Models.YouTube;

/// <summary>
/// Represents a YouTube video.
/// </summary>
internal class Video : Resource
{
    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; private set; }

    [JsonInclude]
    [JsonPropertyName("snippet")]
    public VideoSnippet? Snippet { get; private set; }

    [JsonInclude]
    [JsonPropertyName("contentDetails")]
    public VideoContentDetails? ContentDetails { get; private set; }

    [JsonInclude]
    [JsonPropertyName("statistics")]
    public VideoStatistics? Statistics { get; private set; }

    [JsonInclude]
    [JsonPropertyName("liveStreamingDetails")]
    public VideoLiveStreamingDetails? LiveStreamingDetails { get; private set; }
}