using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.FoodProject
{
    [Produces("application/json")]
    public class Step
    {
        [JsonPropertyName("number")]
        public int Number { get; set; } 

        [JsonPropertyName("step")]
        public string NextStep { get; set; } 

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; } 

        [JsonPropertyName("equipment")]
        public List<Equipment> Equipment { get; set; } 

        [JsonPropertyName("length")]
        public Length Length { get; set; } 
    }
}