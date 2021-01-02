using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.FoodProject
{
    [Produces("application/json")]
    public class Length
    {
        [JsonPropertyName("number")]
        public int Number { get; set; } 

        [JsonPropertyName("unit")]
        public string Unit { get; set; } 
    }
}