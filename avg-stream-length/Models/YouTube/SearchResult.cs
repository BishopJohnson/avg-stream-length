using System.Text.Json.Serialization;

namespace Models.YouTube;

internal class SearchResult : Resource
{
    [JsonInclude]
    [JsonPropertyName("id")]
    public SearchResultId? Id { get; private set; }
}