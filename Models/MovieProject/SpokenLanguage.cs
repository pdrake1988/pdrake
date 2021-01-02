using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class SpokenLanguage
    {
        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; } 

        [JsonPropertyName("iso_639_1")]
        public string Iso6391 { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}