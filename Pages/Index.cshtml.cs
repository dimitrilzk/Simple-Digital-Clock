using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Simple_Digital_Clock.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public DateTime Clock { get; set; }

        public void OnGet()
        {
            var time = DateTime.Now;
            Clock = time;
        }
    }
}
