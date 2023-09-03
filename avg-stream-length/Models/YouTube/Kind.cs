using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Models.YouTube;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
internal enum Kind
{
    [EnumMember(Value = Defs.KindPrefix + "searchListResponse")]
    SearchListResponse,

    [EnumMember(Value = Defs.KindPrefix + "searchResult")]
    SearchResult,

    [EnumMember(Value = Defs.KindPrefix + "video")]
    Video,

    [EnumMember(Value = Defs.KindPrefix + "videoListResponse")]
    VideoListResponse,
}