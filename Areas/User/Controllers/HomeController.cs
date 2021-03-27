using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using popflix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popflix.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.ToListAsync();
            return View(movies);
        }


        [HttpGet]
        public async Task<IActionResult> Index(string MovieSearch)
        {
            ViewData["GetMovies"] = MovieSearch;
            var moviequery = from x in _context.Movies select x;
            if (!String.IsNullOrEmpty(MovieSearch))
            {
                moviequery = moviequery.Where(x => x.Name.Contains(MovieSearch));
            }
            return View(await moviequery.AsNoTracking().ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = await _context.Movies.FindAsync(id);
            return View(movie);
        }

        //for categories
        public async Task<IActionResult> ActionMovies()
        {
            var movies = await _context.Movies.Where(c => c.Category == "0").ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> AdventureMovies()
        {
            var movies = await _context.Movies.Where(c => c.Category == "1").ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> HorrorMovies()
        {
            var movies = await _context.Movies.Where(c => c.Category == "2").ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> CartoonMovies()
        {
            var movies = await _context.Movies.Where(c => c.Category == "3").ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> RomanceMovies()
        {
            var movies = await _context.Movies.Where(c => c.Category == "4").ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> ComedyMovies()
        {
            var movies = await _context.Movies.Where(c => c.Category == "5").ToListAsync();
            return View(movies);
        }
    }
}
