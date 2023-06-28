using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlickGridPoC.Models;

namespace SlickGridPoC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlickGridController : ControllerBase
    {
        private readonly SlickDBContext _dbContext;

        public SlickGridController(SlickDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetMovies")]
        public async Task<ActionResult<List<Movie>>> GetAsync()
        {
            var response = await _dbContext.GetProcedures().GetMoviesAsync();
            return Ok(response);
        }
    }
}
