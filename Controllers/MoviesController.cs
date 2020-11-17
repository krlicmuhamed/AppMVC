using AppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie{ Id = 0, Name = "Shrek", ImageUrl="https://m.media-amazon.com/images/M/MV5BOGZhM2FhNTItODAzNi00YjA0LWEyN2UtNjJlYWQzYzU1MDg5L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                new Movie{ Id = 1, Name = "Wall-e", ImageUrl="https://m.media-amazon.com/images/M/MV5BMjExMTg5OTU0NF5BMl5BanBnXkFtZTcwMjMxMzMzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg"}
            };
            MoviesViewModel viewModel = new MoviesViewModel
            {
                Movies = movies
            };
            return View(viewModel);
        }
    }
}
