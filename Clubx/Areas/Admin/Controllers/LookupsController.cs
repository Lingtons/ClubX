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
    public class LookupsController : Controller
    {
        private readonly ClubxContext _context;

        public LookupsController(ClubxContext context)
        {
            _context = context;
        }

        // GET: Admin/Lookups
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppLookups.ToListAsync());
        }

        // GET: Admin/Lookups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appLookups = await _context.AppLookups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appLookups == null)
            {
                return NotFound();
            }

            return View(appLookups);
        }

        // GET: Admin/Lookups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Lookups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Category,ValueText,Group")] AppLookups appLookups)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appLookups);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appLookups);
        }

        // GET: Admin/Lookups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appLookups = await _context.AppLookups.FindAsync(id);
            if (appLookups == null)
            {
                return NotFound();
            }
            return View(appLookups);
        }

        // POST: Admin/Lookups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Category,ValueText,Group")] AppLookups appLookups)
        {
            if (id != appLookups.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appLookups);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppLookupsExists(appLookups.Id))
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
            return View(appLookups);
        }

        // GET: Admin/Lookups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appLookups = await _context.AppLookups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appLookups == null)
            {
                return NotFound();
            }

            return View(appLookups);
        }

        // POST: Admin/Lookups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appLookups = await _context.AppLookups.FindAsync(id);
            _context.AppLookups.Remove(appLookups);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppLookupsExists(int id)
        {
            return _context.AppLookups.Any(e => e.Id == id);
        }
    }
}
