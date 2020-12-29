using System.Text.Json.Serialization;

namespace pdrake.Models.MovieProject
{
    public class Results
    {
        [JsonPropertyName("CA")]
        public CA CA { get; set; } 

        [JsonPropertyName("US")]
        public US US { get; set; } 
    }
}