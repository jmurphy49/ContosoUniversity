using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoGames.Data;
using VideoGames.Models;

namespace VideoGames.Controllers
{
    public class VideoGamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VideoGamesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: VideoGames
        public async Task<IActionResult> Index(string searchString, string VGPublisher)
        
        {
            IQueryable<string> publisherQuery = from v in _context.VideoGame
                                                orderby v.Publisher
                                                select v.Publisher;

            var videoGameList = from v in _context.VideoGame
                                select v;

            if (!String.IsNullOrEmpty(searchString))
            {
                videoGameList = videoGameList.Where(v => v.Title.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(VGPublisher))
            {
                videoGameList = videoGameList.Where(v => v.Publisher == VGPublisher);
            }

            var VGPublisherVM = new VideoGameViewModel();
            VGPublisherVM.publishers = new SelectList(await publisherQuery.Distinct().ToListAsync());
            VGPublisherVM.videoGames = await videoGameList.ToListAsync();


            return View(VGPublisherVM);


        }

        // GET: VideoGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGame.SingleOrDefaultAsync(m => m.VideoGameID == id);
            if (videoGame == null)
            {
                return NotFound();
            }

            return View(videoGame);
        }

        // GET: VideoGames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VideoGameID,Genre,Platform,Price,Publisher,Rating,ReleaseDate,Title")] VideoGame videoGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(videoGame);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(videoGame);
        }

        // GET: VideoGames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGame.SingleOrDefaultAsync(m => m.VideoGameID == id);
            if (videoGame == null)
            {
                return NotFound();
            }
            return View(videoGame);
        }

        // POST: VideoGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VideoGameID,Genre,Platform,Price,Publisher,Rating,ReleaseDate,Title")] VideoGame videoGame)
        {
            if (id != videoGame.VideoGameID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoGameExists(videoGame.VideoGameID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(videoGame);
        }

        // GET: VideoGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGame = await _context.VideoGame.SingleOrDefaultAsync(m => m.VideoGameID == id);
            if (videoGame == null)
            {
                return NotFound();
            }

            return View(videoGame);
        }

        // POST: VideoGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videoGame = await _context.VideoGame.SingleOrDefaultAsync(m => m.VideoGameID == id);
            _context.VideoGame.Remove(videoGame);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool VideoGameExists(int id)
        {
            return _context.VideoGame.Any(e => e.VideoGameID == id);
        }
    }
}
