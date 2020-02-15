using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Songs;
using Web.Models.Shared;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;

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
                var youtube = YouTube.Default;
                var video = youtube.GetVideo(model.Url);
                string videoId = getVideoId(model);
                string videoName = video.Title.Substring(0, video.Title.Length - 10);
                string videoLink = "https://www.youtube.com/embed/" + videoId;
                Song song = new Song
                {
                    Title = videoName,
                    Rating = 0,
                    Url = videoLink,
                };

                
                
                if (!SongExists(song.Url))
                {
                    _context.Add(song);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    TempData["Fail"] = "Song already exist";
                    return RedirectToAction(nameof(Create));
                }

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        
        public ActionResult DownloadVideo(int id)
        {
            var videoLink = "https://www.youtube.com/watch?v=" + getVideoId(id);
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(videoLink);
            string fileDownloadName = $"{vid.FullName.Substring(0, vid.Title.Length - 10)}.mp3";
            return base.File(vid.GetBytes(), System.Net.Mime.MediaTypeNames.Application.Octet, fileDownloadName);
                        
        }



        private string getVideoId(int songId)
        {
            Song song = _context.Songs.Find(songId);
            string id = song.Url.Remove(0, 30);
            return id;

        }

        private string getVideoId(SongsCreateViewModel model)
        {
            var linkArray = model.Url.ToCharArray();
            string videoId = "";
            for (int i = linkArray.Length - 1; i >= linkArray.Length - 11; i--)
            {
                videoId += linkArray[i];
            }
            string videoIdReversed = "";
            for (int i = videoId.Length - 1; i >= 0; i--)
            {
                videoIdReversed += videoId[i];
            }


            return videoIdReversed;
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
