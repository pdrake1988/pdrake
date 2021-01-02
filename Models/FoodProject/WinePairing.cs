using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace pdrake.Models.FoodProject
{
    public class WinePairing
    {
        [JsonPropertyName("pairedWines")]
        public List<object> PairedWines { get; set; } 

        [JsonPropertyName("pairingText")]
        public string PairingText { get; set; } 

        [JsonPropertyName("productMatches")]
        public List<object> ProductMatches { get; set; } 
    }
}