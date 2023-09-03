using System.Text.Json.Serialization;

namespace Models.YouTube;

internal class ListResponse<TResource> : Resource
    where TResource : Resource
{
    [JsonInclude]
    [JsonPropertyName("nextPageToken")]
    public string? NextPageToken { get; private set; }

    [JsonInclude]
    [JsonPropertyName("prevPageToken")]
    public string? PrevPageToken { get; private set; }

    [JsonInclude]
    [JsonPropertyName("pageInfo")]
    public PageInfo? PageInfo { get; private set; }

    [JsonInclude]
    [JsonPropertyName("items")]
    public IEnumerable<TResource>? Items { get; private set; }
}