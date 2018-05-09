using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using DoorToDoor_Every_1.Models;
using DoorToDoor_Every_1.Models.AccountViewModels;
using DoorToDoor_Every_1.Services;
using DoorToDoor_Every_1.Data;

namespace DoorToDoor_Every_1.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(ApplicationDbContext pContext, SignInManager<ApplicationUser> pSignInManager, ILogger<AccountController> logger)
        {
            userManager = pSignInManager.UserManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            users = userManager.Users.ToList();

            return View(users);
        }


    }
}
