using Microsoft.AspNetCore.Mvc;

namespace pdrake.Controllers
{
    public class ChessController : Controller
    {
        public IActionResult Game()
        {
            return View();
        }
    }
}