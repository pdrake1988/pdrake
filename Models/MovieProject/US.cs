using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class US
    {
        [JsonPropertyName("link")]
        public string Link { get; set; } 

        [JsonPropertyName("flatrate")]
        public List<Flatrate> Flatrate { get; set; } 
    }
}