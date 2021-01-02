using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.FoodProject
{
    [Produces("application/json")]
    public class AnalyzedInstruction
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("steps")]
        public List<Step> Steps { get; set; } 
    }
}