using System.Text.Json.Serialization;

namespace Models.YouTube;

public class VideoLiveStreamingDetails
{
    [JsonInclude]
    [JsonPropertyName("actualStartTime")]
    public DateTime? ActualStartTime { get; private set; }

    [JsonInclude]
    [JsonPropertyName("actualStartTime")]
    public DateTime? ActualEndTime { get; private set; }

    [JsonInclude]
    [JsonPropertyName("scheduledStartTime")]
    public DateTime? ScheduledStartTime { get; private set; }

    [JsonInclude]
    [JsonPropertyName("scheduledEndTime")]
    public DateTime? ScheduledEndTime { get; private set; }

    [JsonInclude]
    [JsonPropertyName("concurrentViewers")]
    public ulong? ConcurrentViewers { get; private set; }

    [JsonInclude]
    [JsonPropertyName("activeLiveChatId")]
    public string? ActiveLiveChatId { get; private set; }
}