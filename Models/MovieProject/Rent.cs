﻿using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class Rent
    {
        [JsonPropertyName("display_priority")]
        public int DisplayPriority { get; set; } 

        [JsonPropertyName("logo_path")]
        public string LogoPath { get; set; } 

        [JsonPropertyName("provider_id")]
        public int ProviderId { get; set; } 

        [JsonPropertyName("provider_name")]
        public string ProviderName { get; set; }
    }
}