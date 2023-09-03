using System.Text.Json.Serialization;

namespace Models.YouTube;

internal class SearchListResponse : ListResponse<SearchResult>
{
    [JsonInclude]
    [JsonPropertyName("regionCode")]
    public string? RegionCode { get; private set; }
}