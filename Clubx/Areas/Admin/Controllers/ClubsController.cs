using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;

namespace Clubx.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClubsController : Controller
    {
        private readonly ClubxContext _context;

        public ClubsController(ClubxContext context)
        {
            _context = context;
        }

        // GET: Admin/Clubs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clubs.ToListAsync());
        }

        // GET: Admin/Clubs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubs = await _context.Clubs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubs == null)
            {
                return NotFound();
            }

            return View(clubs);
        }

        // GET: Admin/Clubs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Clubs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,ImageUrl,HasMembershipFee")] Clubs clubs)
        {
            if (ModelState.IsValid)
            {
                clubs.Id = Guid.NewGuid();
                _context.Add(clubs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clubs);
        }

        // GET: Admin/Clubs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubs = await _context.Clubs.FindAsync(id);
            if (clubs == null)
            {
                return NotFound();
            }
            return View(clubs);
        }

        // POST: Admin/Clubs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Description,ImageUrl,HasMembershipFee")] Clubs clubs)
        {
            if (id != clubs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clubs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClubsExists(clubs.Id))
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
            return View(clubs);
        }

        // GET: Admin/Clubs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubs = await _context.Clubs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubs == null)
            {
                return NotFound();
            }

            return View(clubs);
        }

        // POST: Admin/Clubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var clubs = await _context.Clubs.FindAsync(id);
            _context.Clubs.Remove(clubs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubsExists(Guid id)
        {
            return _context.Clubs.Any(e => e.Id == id);
        }
    }
}
