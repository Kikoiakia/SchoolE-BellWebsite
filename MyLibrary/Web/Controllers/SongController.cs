using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Songs;
using Web.Models.Shared;

namespace Web.Controllers
{
    public class SongController : Controller
    {
        private readonly SongDb _context;
        private const int PageSize = 10;

        public SongController()
        {
            _context = new SongDb();
        }

        // GET: Songs
        public async Task<IActionResult> Index(SongsIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<SongViewModel> items = await _context.Songs.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(s => new SongViewModel()
            {
                Id = s.Id,
                Title = s.Title,
                Thumbnail = s.Thumbnail,
                Rating = s.Rating,                
                Url = s.Url,                

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Songs.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Songs/Create
        public IActionResult Create()
        {
            SongsCreateViewModel model = new SongsCreateViewModel();

            return View(model);
        }

        // POST: Songs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SongsCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Song song = new Song
                {
                    Title = model.Title,
                    Thumbnail = model.Thumbnail,
                    Rating = model.Rating,
                    Url = model.Url,
                };

                _context.Add(song);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Songs/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Song song = await _context.Songs.FindAsync(id);
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool SongExists(string url)
        {
            return _context.Songs.Any(e => e.Url == url);
        }
    }
}
