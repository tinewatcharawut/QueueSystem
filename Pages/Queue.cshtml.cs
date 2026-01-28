using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace QueueSystem.Pages;

public class QueueModel : PageModel
{
    private readonly QueueService _queueService;

    public string Queue { get; set; } = "";
    public string QueueTime { get; set; } = "";

    public QueueModel(QueueService queueService)
    {
        _queueService = queueService;
    }

    public void OnGet()
    {
        Queue = _queueService.CurrentQueue;
        var dt = _queueService.LastQueueTime;
        QueueTime = string.Format(
        CultureInfo.InvariantCulture,
        "วันที่ : {0:dd/MM/yyyy}   เวลา {0:HH:mm} น.",
        dt
    );
    }
}
