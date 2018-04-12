using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoorToDoor_Every_1.Data;
using DoorToDoor_Every_1.Models;
using DoorToDoor_Every_1.Operations;
using Microsoft.EntityFrameworkCore.Extensions.Internal;

namespace DoorToDoor_Every_1.Controllers
{
    public class AddressesController : Controller
    {
        private readonly DoorContext _context;

        public AddressesController(DoorContext context)
        {
            _context = context;
        }

        // GET: Addresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Addresses.ToListAsync());
        }

        // GET: Addresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = await _context.Addresses
                .SingleOrDefaultAsync(m => m.Id == id);
            DatabaseManager.AddressId = (int)id;
            FindAddress(id);
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        // GET: Addresses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Addresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Unit,StreetNumber,StreetName,Suburb,City,Country,Postcode,DoorAnswered,Interested,Notes,Visited,FollowUp")] Address address)
        {
            if (ModelState.IsValid)
            {
                _context.Add(address);
                await _context.SaveChangesAsync();

                //redirects you to details/3 for example
                return RedirectToAction("Details", new { address.Id });
                //https://forums.asp.net/t/1909349.aspx?Returning+view+that+is+in+different+folder
            }
            return View(address);
        }

        //public ActionResult Details(int addressId)
        //{
        //    var details = GetAddressDetails(addressId); //load details
        //    return View(details);
        //}

        // GET: Addresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = await _context.Addresses.SingleOrDefaultAsync(m => m.Id == id);
            if (address == null)
            {
                return NotFound();
            }
            return View(address);
        }

        // POST: Addresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Unit,StreetNumber,StreetName,Suburb,City,Country,Postcode,DoorAnswered,Interested,Notes,Visited,FollowUp")] Address address)
        {
            if (id != address.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(address);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressExists(address.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { address.Id });
            }
            return View(address);
        }

        // GET: Addresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = await _context.Addresses
                .SingleOrDefaultAsync(m => m.Id == id);
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var address = await _context.Addresses.SingleOrDefaultAsync(m => m.Id == id);
            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressExists(int id)
        {
            return _context.Addresses.Any(e => e.Id == id);
        }

        public void FindAddress(int? id)
        {
            if (id == null)
            {
                //return ControllerBase.NotFound();
            }

            //
            Address address = _context.Addresses.SingleOrDefault(m => m.Id == DatabaseManager.AddressId);
            string unit = address.Unit;
            string number = address.StreetNumber.ToString();
            string name = address.StreetName;
            string suburb = address.Suburb;
            string city = address.City;
            string country = address.Country;
            string postcode = address.Postcode;

            DatabaseManager.Address = (unit + " " + number + " " + name + ", " + suburb + ", " + city + ", " + country + " " + postcode);
        }
    }
}
