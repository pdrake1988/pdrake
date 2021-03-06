﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pdrake.Models.MovieProject;

namespace pdrake.Controllers
{
    public class MovieController : Controller
    {
        public async Task<ActionResult> GetMovies(int genreId = 0, int page = 1)
        {
            using HttpClient httpClient = new HttpClient();
            if (genreId == 0)
            {
                var apiResponse = await httpClient.GetStreamAsync(
                    "https://api.themoviedb.org/3/discover/movie?api_key=e2e4f004450c3b2d09d61c0fb5120d06&language=en-US&sort_by=popularity.desc&include_adult=true&include_video=true&page=" + page);
                ViewData["movies"] = await JsonSerializer.DeserializeAsync<MovieResults>(apiResponse);
            }

            else
            {
                var apiResponse = await httpClient.GetStreamAsync(
                    "https://api.themoviedb.org/3/discover/movie?api_key=e2e4f004450c3b2d09d61c0fb5120d06&language=en-US&sort_by=popularity.desc&include_adult=true&include_video=true&with_genres=" + genreId + "&page=" + page);
                ViewData["movies"] = await JsonSerializer.DeserializeAsync<MovieResults>(apiResponse);
            }
            return View();
        }

        public async Task<ActionResult> MoviePage(int movieId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var apiResponse = await httpClient.GetStreamAsync("https://api.themoviedb.org/3/movie/" + movieId + "?api_key=e2e4f004450c3b2d09d61c0fb5120d06&language=en-US");
                var movieProviders = await httpClient.GetStreamAsync("https://api.themoviedb.org/3/movie/" + movieId + "/watch/providers?api_key=e2e4f004450c3b2d09d61c0fb5120d06");
                ViewData["movieProviders"] = await JsonSerializer.DeserializeAsync<Root>(movieProviders);
                ViewData["movieResults"] = await JsonSerializer.DeserializeAsync<Root>(apiResponse);
                return View();
            }
        }
    }
}