using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.FoodProject
{
    [Produces("application/json")]
    public class Us
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; } 

        [JsonPropertyName("unitShort")]
        public string UnitShort { get; set; } 

        [JsonPropertyName("unitLong")]
        public string UnitLong { get; set; }   
    }
}