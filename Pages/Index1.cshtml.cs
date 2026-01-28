// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;

// namespace QueueSystem.Pages;

// public class IndexModel : PageModel
// {
//     private readonly QueueService _queue;

//     public IndexModel(QueueService queue)
//     {
//         _queue = queue;
//     }

//     public IActionResult OnPostGetQueue()
//     {
//         _queue.NextQueue();
//         return RedirectToPage("Queue");
//     }

//     public IActionResult OnPostClear()
//     {
//         return RedirectToPage("Clear");
//     }
// }
