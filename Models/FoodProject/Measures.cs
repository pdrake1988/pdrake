using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.FoodProject
{
    [Produces("applicaiton/json")]
    public class Measures
    {
        [JsonPropertyName("us")]
        public Us Us { get; set; } 

        [JsonPropertyName("metric")]
        public Metric Metric { get; set; } 
    }
}