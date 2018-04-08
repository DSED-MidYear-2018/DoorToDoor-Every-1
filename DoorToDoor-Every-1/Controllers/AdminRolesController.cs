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
    public class AdminRolesController : Controller
    {
        private readonly DoorContext _context;

        public AdminRolesController(DoorContext context)
        {
            _context = context;
        }

        // GET: AdminRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdminRole.ToListAsync());
        }

        // GET: AdminRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminRole = await _context.AdminRole
                .SingleOrDefaultAsync(m => m.Id == id);
            if (adminRole == null)
            {
                return NotFound();
            }

            return View(adminRole);
        }

        // GET: AdminRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Role")] AdminRole adminRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminRole);
        }

        // GET: AdminRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminRole = await _context.AdminRole.SingleOrDefaultAsync(m => m.Id == id);
            if (adminRole == null)
            {
                return NotFound();
            }
            return View(adminRole);
        }

        // POST: AdminRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Role")] AdminRole adminRole)
        {
            if (id != adminRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminRoleExists(adminRole.Id))
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
            return View(adminRole);
        }

        // GET: AdminRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminRole = await _context.AdminRole
                .SingleOrDefaultAsync(m => m.Id == id);
            if (adminRole == null)
            {
                return NotFound();
            }

            return View(adminRole);
        }

        // POST: AdminRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminRole = await _context.AdminRole.SingleOrDefaultAsync(m => m.Id == id);
            _context.AdminRole.Remove(adminRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminRoleExists(int id)
        {
            return _context.AdminRole.Any(e => e.Id == id);
        }
    }
}
