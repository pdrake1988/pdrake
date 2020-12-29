using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace pdrake.Models.MovieProject
{
    public class CA
    {
        [JsonPropertyName("link")]
        public string Link { get; set; } 

        [JsonPropertyName("rent")]
        public List<Rent> Rent { get; set; } 
    }
}