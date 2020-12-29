using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace pdrake.Models.MovieProject
{
    public class US
    {
        [JsonPropertyName("link")]
        public string Link { get; set; } 

        [JsonPropertyName("flatrate")]
        public List<Flatrate> Flatrate { get; set; } 
    }
}