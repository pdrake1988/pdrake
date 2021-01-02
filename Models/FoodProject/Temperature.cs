using System.Text.Json.Serialization;

namespace pdrake.Models.FoodProject
{
    public class Temperature
    {
        [JsonPropertyName("number")]
        public double Number { get; set; } 

        [JsonPropertyName("unit")]
        public string Unit { get; set; } 
    }
}