namespace AvgStreamLengthApp.Models;

internal class StreamsStatistic
{
    public string? Id { get; set; }

    public string ChannelId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int AverageLength { get; set; }

    public int Longest { get; set; }

    public int Shortest { get; set; }
}