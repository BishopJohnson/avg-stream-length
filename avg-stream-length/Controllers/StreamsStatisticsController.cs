using AvgStreamLengthApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvgStreamLengthApp.Controllers;

[ApiController]
[Route("[controller]/{channelId:length(24)}")]
internal class StreamsStatisticsController : Controller
{
    private readonly ILogger<StreamsStatisticsController> _logger;

    private static readonly Dictionary<string, StreamsStatistic> STUB_STATISTICS = new()
    {
        { "UC8rcEBzJSleTkf_-agPM20g", new StreamsStatistic() },
    };

    public StreamsStatisticsController(ILogger<StreamsStatisticsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<StreamsStatistic> Get(string channelId)
    {
        STUB_STATISTICS.TryGetValue(channelId, out StreamsStatistic? statistic);

        if (statistic is null)
        {
            return NotFound();
        }

        return statistic;
    }
}