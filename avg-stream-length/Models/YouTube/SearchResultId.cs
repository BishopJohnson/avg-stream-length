using System.Text.Json.Serialization;

namespace Models.YouTube;

internal class SearchResultId
{
    [JsonInclude]
    [JsonPropertyName("kind")]
    public Kind? Kind { get; private set; }

    [JsonInclude]
    [JsonPropertyName("videoId")]
    public string? VideoId { get; private set; }
}