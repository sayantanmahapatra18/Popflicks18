using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using popflix.Data;
using popflix.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace popflix.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class DashBoard : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashBoard(ApplicationDbContext _context)
        {
            this._context = _context;
        }


        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.ToListAsync();
            return View(movies);
        }

        public IActionResult Add()
        {
            return View();
        }


        //saving in db
        [HttpPost, ActionName("Add")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Added(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    movie.Banner = p1;
                }
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        //detail view
        public async Task<IActionResult> Movie(int? id, Movie cat)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            return View(movie);
        }

        //edit page
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = await _context.Movies.FindAsync(id);
            return View(movie);
        }

        //edit and save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Movie mov)
        {
            var movieFromDb = await _context.Movies.Where(c => c.Id == mov.Id).FirstOrDefaultAsync();
            if (movieFromDb == null)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    movieFromDb.Banner = p1;
                }
                movieFromDb.Name = mov.Name;
                movieFromDb.About = mov.About;
                movieFromDb.Category = mov.Category;
                movieFromDb.Director = mov.Director;
                movieFromDb.Actors = mov.Actors;
                movieFromDb.Producer = mov.Producer;
                movieFromDb.WatchTime = mov.WatchTime;
                movieFromDb.Release = mov.Release;
                movieFromDb.Ratings = mov.Ratings;
                movieFromDb.MovieLink = mov.MovieLink;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mov);
        }

        public async Task<IActionResult> Delete(Movie mov)
        {
            var movieFromDb = await _context.Movies.Where(c => c.Id == mov.Id).FirstOrDefaultAsync();
            if (movieFromDb == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(mov);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}