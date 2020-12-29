using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class BelongsToCollection
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } 

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } 
    }
}