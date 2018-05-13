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
    public class FollowUpsController : Controller
    {
        private readonly DoorContext _context;

        public FollowUpsController(DoorContext context)
        {
            _context = context;
        }

        // GET: FollowUps
        public async Task<IActionResult> Index()
        {
            //var fu = _context.FollowUps.ToList();
            //// var followup = new list<FollowUp>;
            //List<FollowUp> allfu = new List<FollowUp>();

            //FollowUp singlefu = new FollowUp();

            //foreach (var item in fu)
            //{
            //    singlefu.DateReturn = item.DateReturn.Date;


            //    allfu.Add(singlefu);
            //}
            //return View(await allfu);

            //int day;
            //int month;
            //int year;
            string sd;
            FollowUp _myFollowUp = new FollowUp();
            var fu = _context.FollowUps;

            //foreach (var item in fu)
            //{
            //    //day = item.DateReturn.Date.Day;
            //    //month = item.DateReturn.Date.Month;
            //    //year = item.DateReturn.Date.Year;
            //    //sd = day + "/" + month + "/" + year;

            //    //sd = item.DateReturn.ToShortDateString();

            //    //item.DateReturn = Convert.ToDateTime(sd).Date;
            //    _myFollowUp.ShortDate();
            //}


            return View(await fu.ToListAsync());
        }

        // GET: FollowUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followUp = await _context.FollowUps
                .SingleOrDefaultAsync(m => m.Id == id);
            if (followUp == null)
            {
                return NotFound();
            }

            return View(followUp);
        }

        // GET: FollowUps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FollowUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateReturn,TimeReturn,AddressId")] FollowUp followUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(followUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(followUp);
        }

        // GET: FollowUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //This is an awesome comment
            var followUp = await _context.FollowUps.SingleOrDefaultAsync(m => m.Id == id);
            if (followUp == null)
            {
                return NotFound();
            }
            return View(followUp);
        }

        // POST: FollowUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateReturn,TimeReturn")] FollowUp followUp)
        {
            if (id != followUp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(followUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FollowUpExists(followUp.Id))
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
            return View(followUp);
        }

        // GET: FollowUps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followUp = await _context.FollowUps
                .SingleOrDefaultAsync(m => m.Id == id);
            if (followUp == null)
            {
                return NotFound();
            }

            return View(followUp);
        }

        // POST: FollowUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var followUp = await _context.FollowUps.SingleOrDefaultAsync(m => m.Id == id);
            _context.FollowUps.Remove(followUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FollowUpExists(int id)
        {
            return _context.FollowUps.Any(e => e.Id == id);
        }
    }
}
