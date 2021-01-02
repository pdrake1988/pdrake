using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class Results
    {
        [JsonPropertyName("CA")]
        public CA CA { get; set; } 

        [JsonPropertyName("US")]
        public US US { get; set; } 
    }
}