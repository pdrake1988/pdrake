using Microsoft.AspNetCore.Mvc;

namespace pdrake.Controllers
{
    public class ChessController : Controller
    {
        // GET
        public IActionResult Game()
        {
            return View();
        }
    }
}