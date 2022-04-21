#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationUsingSoftUniDB.Models;

namespace WebApplicationUsingSoftUniDB.Controllers
{
    public class TownsController : Controller
    {
        private readonly SoftUniContext _context;

        public TownsController(SoftUniContext context)
        {
            _context = context;
        }

        // GET: Towns
        public async Task<IActionResult> Index()
        {
            return View(await _context.Towns.ToListAsync());
        }

        // GET: Towns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Towns
                .FirstOrDefaultAsync(m => m.TownId == id);
            if (town == null)
            {
                return NotFound();
            }

            return View(town);
        }

        // GET: Towns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Towns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TownId,Name")] Town town)
        {
            if (ModelState.IsValid)
            {
                _context.Add(town);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(town);
        }

        // GET: Towns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Towns.FindAsync(id);
            if (town == null)
            {
                return NotFound();
            }
            return View(town);
        }

        // POST: Towns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TownId,Name")] Town town)
        {
            if (id != town.TownId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(town);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TownExists(town.TownId))
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
            return View(town);
        }

        // GET: Towns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Towns
                .FirstOrDefaultAsync(m => m.TownId == id);
            if (town == null)
            {
                return NotFound();
            }

            return View(town);
        }

        // POST: Towns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var town = await _context.Towns.FindAsync(id);
            _context.Towns.Remove(town);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TownExists(int id)
        {
            return _context.Towns.Any(e => e.TownId == id);
        }
    }
}
