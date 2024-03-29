using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AnimeTrackingWeb.Services;
using Quartz;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace AnimeTrackingWeb.Controllers;

[ApiController]
[Route("/api/bot")]
public class BotController : ControllerBase
{
    [HttpPost]
    // [ValidateTelegramBot]
    public async Task<IActionResult> Post([FromBody] Update update,
        [FromServices] UpdateHandlers handleUpdateService,
        [FromServices] ISchedulerFactory schedulerFactory,
        CancellationToken cancellationToken)
    {
        await handleUpdateService.HandleUpdateAsync(update, schedulerFactory, cancellationToken);
        return Ok();
    }
}