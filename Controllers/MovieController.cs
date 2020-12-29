using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pdrake.Models.MovieProject;

namespace pdrake.Controllers
{
    public class MovieController : Controller
    {
        public async Task<MovieResults> GetMovies()
        {
            return View();
        }
    }
}