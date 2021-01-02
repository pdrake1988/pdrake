﻿using System.Collections.Generic;
using System.Net.Mime;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace pdrake.Models.MovieProject
{
    [Produces("application/json")]
    public class Root
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("results")]
        public Results Results { get; set; } 
        
        [JsonPropertyName("adult")]
        public bool Adult { get; set; } 

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } 

        [JsonPropertyName("belongs_to_collection")]
        public BelongsToCollection BelongsToCollection { get; set; } 

        [JsonPropertyName("budget")]
        public int Budget { get; set; } 

        [JsonPropertyName("genres")]
        public List<Genre> Genres { get; set; } 

        [JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; } 

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; } 

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } 

        [JsonPropertyName("overview")]
        public string Overview { get; set; } 

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; } 

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } 

        [JsonPropertyName("production_companies")]
        public List<ProductionCompany> ProductionCompanies { get; set; } 

        [JsonPropertyName("production_countries")]
        public List<ProductionCountry> ProductionCountries { get; set; } 

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; } 

        [JsonPropertyName("revenue")]
        public int Revenue { get; set; } 

        [JsonPropertyName("runtime")]
        public int Runtime { get; set; } 

        [JsonPropertyName("spoken_languages")]
        public List<SpokenLanguage> SpokenLanguages { get; set; } 

        [JsonPropertyName("status")]
        public string Status { get; set; } 

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; } 

        [JsonPropertyName("title")]
        public string Title { get; set; } 

        [JsonPropertyName("video")]
        public bool Video { get; set; } 

        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; } 

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; } 
    }
}