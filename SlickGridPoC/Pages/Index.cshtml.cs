using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SlickGridPoC.Models;

namespace SlickGridPoC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SlickDBContext _dbContext;

        public IndexModel(ILogger<IndexModel> logger, SlickDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task OnGet()
        {
            var response = await _dbContext.GetProcedures().GetMoviesAsync();
            if (response.Count > 0)
            {

            }
        }
    }
}