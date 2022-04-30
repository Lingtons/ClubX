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
    public class ClubSchedulesController : Controller
    {
        private readonly ClubxContext _context;

        public ClubSchedulesController(ClubxContext context)
        {
            _context = context;
        }

        // GET: Admin/ClubSchedules
        public async Task<IActionResult> Index()
        {
            var clubxContext = _context.ClubSchedules.Include(c => c.Club).Include(c => c.Location);
            return View(await clubxContext.ToListAsync());
        }

        // GET: Admin/ClubSchedules/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubSchedule = await _context.ClubSchedules
                .Include(c => c.Club)
                .Include(c => c.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubSchedule == null)
            {
                return NotFound();
            }

            return View(clubSchedule);
        }

        // GET: Admin/ClubSchedules/Create
        public IActionResult Create()
        {
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name");
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name");
            return View();
        }

        // POST: Admin/ClubSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LocationId,ClubId,ClubDay,ClubStartTime,ClubEndTime,SessionTitle,ExpirationDate,Capacity,Virtual,VirtualLink")] ClubSchedule clubSchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clubSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name", clubSchedule.ClubId);
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", clubSchedule.LocationId);
            return View(clubSchedule);
        }

        // GET: Admin/ClubSchedules/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubSchedule = await _context.ClubSchedules.FindAsync(id);
            if (clubSchedule == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name", clubSchedule.ClubId);
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", clubSchedule.LocationId);
            return View(clubSchedule);
        }

        // POST: Admin/ClubSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,LocationId,ClubId,ClubDay,ClubStartTime,ClubEndTime,SessionTitle,ExpirationDate,Capacity,Virtual,VirtualLink")] ClubSchedule clubSchedule)
        {
            if (id != clubSchedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clubSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClubScheduleExists(clubSchedule.Id))
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
            ViewData["ClubId"] = new SelectList(_context.Clubs, "Id", "Name", clubSchedule.ClubId);
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", clubSchedule.LocationId);
            return View(clubSchedule);
        }

        // GET: Admin/ClubSchedules/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubSchedule = await _context.ClubSchedules
                .Include(c => c.Club)
                .Include(c => c.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubSchedule == null)
            {
                return NotFound();
            }

            return View(clubSchedule);
        }

        // POST: Admin/ClubSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var clubSchedule = await _context.ClubSchedules.FindAsync(id);
            _context.ClubSchedules.Remove(clubSchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubScheduleExists(long id)
        {
            return _context.ClubSchedules.Any(e => e.Id == id);
        }
    }
}
