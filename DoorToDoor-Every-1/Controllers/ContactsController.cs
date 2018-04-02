using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoorToDoor_Every_1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Interested()
        {
            return View();
        }

        public IActionResult NotInterested()
        {
            return View();
        }

        public IActionResult NotHome()
        {
            return View();
        }

        public IActionResult FollowUp()
        {
            return View();
        }
    }
}