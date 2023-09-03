using System.Text.Json.Serialization;

namespace Models.YouTube;

public class VideoStatistics
{
    [JsonInclude]
    [JsonPropertyName("viewCount")]
    public string? ViewCount { get; private set; }

    [JsonInclude]
    [JsonPropertyName("likeCount")]
    public string? LikeCount { get; private set; }

    [JsonInclude]
    [JsonPropertyName("dislikeCount")]
    public string? DislikeCount { get; private set; }

    [JsonInclude]
    [JsonPropertyName("favoriteCount")]
    public string? FavoriteCount { get; private set; }

    [JsonInclude]
    [JsonPropertyName("commentCount")]
    public string? CommentCount { get; private set; }
}