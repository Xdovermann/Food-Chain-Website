using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodChainWebApp.Data;
using FoodChainWebApp.Models;

namespace FoodChainWebApp.Controllers
{
    public class LeaderBoardEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeaderBoardEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LeaderBoardEntries
        public async Task<IActionResult> Index()
        {
            return View(await _context.LeaderBoardEntry.ToListAsync());
        }

        // GET: filter leaderbord
        public async Task<IActionResult> FilterLeaderBoard()
        {
            return View();
        }

        // POST: shows filtered leaderbord on username  
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View("Index",await _context.LeaderBoardEntry.Where( j => j.Username.Contains(SearchPhrase)).ToListAsync());
        }

        // loads the page with the unity login
        public async Task<IActionResult> LoginUnity()
        {
            return View("UnityLogin");
        }

        // GET: LeaderBoardEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaderBoardEntry = await _context.LeaderBoardEntry
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaderBoardEntry == null)
            {
                return NotFound();
            }

            return View(leaderBoardEntry);
        }

        // GET: LeaderBoardEntries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaderBoardEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Score")] LeaderBoardEntry leaderBoardEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leaderBoardEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaderBoardEntry);
        }

        // GET: LeaderBoardEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaderBoardEntry = await _context.LeaderBoardEntry.FindAsync(id);
            if (leaderBoardEntry == null)
            {
                return NotFound();
            }
            return View(leaderBoardEntry);
        }

        // POST: LeaderBoardEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Score")] LeaderBoardEntry leaderBoardEntry)
        {
            if (id != leaderBoardEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaderBoardEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaderBoardEntryExists(leaderBoardEntry.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaderBoardEntry);
        }

        // GET: LeaderBoardEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaderBoardEntry = await _context.LeaderBoardEntry
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaderBoardEntry == null)
            {
                return NotFound();
            }

            return View(leaderBoardEntry);
        }

        // POST: LeaderBoardEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaderBoardEntry = await _context.LeaderBoardEntry.FindAsync(id);
            _context.LeaderBoardEntry.Remove(leaderBoardEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaderBoardEntryExists(int id)
        {
            return _context.LeaderBoardEntry.Any(e => e.Id == id);
        }
    }
}
