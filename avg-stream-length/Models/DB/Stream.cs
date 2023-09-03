using System.Text.Json.Serialization;

namespace Models.DB;

internal class Stream
{
    [JsonInclude]
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; private set; }

    [JsonInclude]
    [JsonPropertyName("averageLength")]
    public int? AverageLength { get; private set; }
}