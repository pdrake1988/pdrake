using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class MovieResults : Movie
    {
        [JsonPropertyName("page")]
        public int Page { get; set; } 

        [JsonPropertyName("results")]
        public List<Movie> Results { get; set; } 

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; } 

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; } 
    }
}