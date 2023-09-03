using System.Text.Json.Serialization;

namespace Models.YouTube;

internal class PageInfo
{
    [JsonInclude]
    [JsonPropertyName("totalResults")]
    public int? TotalResults { get; private set; }

    [JsonInclude]
    [JsonPropertyName("resultsPerPage")]
    public int? ResultsPerPage { get; private set; }
}