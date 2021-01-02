using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pdrake.Models.FoodProject;

namespace pdrake.Controllers
{
    public class FoodController : Controller
    {
        public async Task<ActionResult> GetRecipes(int number = 16)
        {
            using HttpClient httpClient = new HttpClient();
            var apiResponse =
                await httpClient.GetStreamAsync(
                    "https://api.spoonacular.com/recipes/random?apiKey=12969f0391094641a81e093fada49022&number=" + number);
            ViewData["randomRecipes"] = await JsonSerializer.DeserializeAsync<Root>(apiResponse);
            return View();
        }

        public async Task<ActionResult> Recipe(int recipeId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var apiResponse =
                    await httpClient.GetStreamAsync("https://api.spoonacular.com/recipes/"+ recipeId +"/analyzedInstructions");
                ViewData["recipeInfo"] = await JsonSerializer.DeserializeAsync<Root>(apiResponse);
                return View();
            }
        }
    }
}