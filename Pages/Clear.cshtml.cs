using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QueueSystem.Pages;

public class ClearModel : PageModel
{
    private readonly QueueService _queueService;

    public string Queue { get; set; } = "";

    public ClearModel(QueueService queueService)
    {
        _queueService = queueService;
    }

    public void OnGet()
    {
        Queue = _queueService.CurrentQueue;
    }

    public void OnPost()
    {
        _queueService.Reset();
        Queue = _queueService.CurrentQueue;
    }
}
