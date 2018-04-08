using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoorToDoor_Every_1.Data;
using DoorToDoor_Every_1.Models;

namespace DoorToDoor_Every_1.Controllers
{
    public class OccurancesController : Controller
    {
        private readonly DoorContext _context;

        public OccurancesController(DoorContext context)
        {
            _context = context;
        }

        // GET: Occurances
        public async Task<IActionResult> Index()
        {
            return View(await _context.Occurances.ToListAsync());
        }

        // GET: Occurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var occurance = await _context.Occurances
                .SingleOrDefaultAsync(m => m.Id == id);
            if (occurance == null)
            {
                return NotFound();
            }

            return View(occurance);
        }

        // GET: Occurances/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Occurances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] Occurance occurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(occurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(occurance);
        }

        // GET: Occurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var occurance = await _context.Occurances.SingleOrDefaultAsync(m => m.Id == id);
            if (occurance == null)
            {
                return NotFound();
            }
            return View(occurance);
        }

        // POST: Occurances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] Occurance occurance)
        {
            if (id != occurance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(occurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OccuranceExists(occurance.Id))
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
            return View(occurance);
        }

        // GET: Occurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var occurance = await _context.Occurances
                .SingleOrDefaultAsync(m => m.Id == id);
            if (occurance == null)
            {
                return NotFound();
            }

            return View(occurance);
        }

        // POST: Occurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var occurance = await _context.Occurances.SingleOrDefaultAsync(m => m.Id == id);
            _context.Occurances.Remove(occurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OccuranceExists(int id)
        {
            return _context.Occurances.Any(e => e.Id == id);
        }
    }
}
