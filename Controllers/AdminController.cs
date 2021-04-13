using FagElGamous.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private FagElGamousContext _context;

        public AdminController(RoleManager<IdentityRole> roleManager,
                                UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = (from user in _context.Users
                        join userRole in _context.UserRoles
                        on user.Id equals userRole.UserId
                        join role in _context.Roles
                        on userRole.RoleId equals role.Id
                        select user)
                        .ToListAsync();
            return View(users);
        }
    }
}
