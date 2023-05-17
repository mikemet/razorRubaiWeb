using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorRubaiWeb.Pages
{
    public class RandomModel : PageModel
    {
        private readonly ILogger<RandomModel> _logger;

        public RandomModel(ILogger<RandomModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}