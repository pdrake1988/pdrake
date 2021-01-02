using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.FoodProject
{
    [Produces("application/json")]
    public class Root
    {
        [JsonPropertyName("recipes")]
        public List<Recipe> Recipes { get; set; }
    }
}