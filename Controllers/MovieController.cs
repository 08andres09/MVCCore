using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndresMovieApp.Models;
using System.Net.Http;
using System.Text.Json;

namespace AndresMovieApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(HttpClient client)
        {
            HttpClient clientMovie = new HttpClient();

            var response = clientMovie.GetAsync("https://api.themoviedb.org/3/movie/top_rated?api_key=b8a04548b32ce58f94981e4ae8081090&page=2");
            var responseString = response.Result.Content.ReadAsStringAsync().Result;
            var movies = JsonSerializer.Deserialize<MoviesResponse>(responseString);
            

            var movie = new Movie()
            {
                Title = "Peli 1",
                VoteAverage = 5.5
            };
       
            return View(movie);
        }
    }
}
