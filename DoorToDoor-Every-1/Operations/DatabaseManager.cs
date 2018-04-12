using System.Net.Mime;
using DoorToDoor_Every_1.Data;
using DoorToDoor_Every_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DoorToDoor_Every_1.Operations
{
    public class DatabaseManager
    {
        private SqliteConnection db;

        private readonly DoorContext _context;


        public static int AddressId { get; set; }
        public static string Address { get; set; }



        public DatabaseManager(DoorContext context)
        {
            //DBConnect();
            _context = context;
        }

        //private void DBConnect()
        //{
        //    //db=new SqliteConnection(System.IO.Path.GetDirectoryName(), "door.db");
        //}


        //// GET: Addresses/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var address = await _context.Addresses
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    DatabaseManager.AddressId = (int)id;
        //    if (address == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(address);
        //}


        public void FindAddress(int? id)
        {
            if (id == null)
            {
                //return ControllerBase.NotFound();
            }

            var address = _context.Addresses.SingleOrDefaultAsync(m => m.Id == AddressId);
            Address = address.ToString();


            //return View(address);
        }
    }
}
