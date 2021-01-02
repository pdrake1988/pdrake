using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class CA
    {
        [JsonPropertyName("link")]
        public string Link { get; set; } 

        [JsonPropertyName("rent")]
        public List<Rent> Rent { get; set; } 
    }
}