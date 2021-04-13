using FagElGamous.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Controllers
{
    /*[Authorize(Roles = "Admin")]*/
    public class AdminController : Controller
    {
        private readonly FagElGamousContext _context;

        public AdminController(FagElGamousContext context)
        {
            _context = context;
        }

        // GET: C14
        public async Task<IActionResult> Index()
        {
            var FagElGamousContext = _context.Users.Include(c => c.Id);
            return View(await FagElGamousContext.ToListAsync());
        }

        // GET: C14/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(c => c.Id)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: C14/Create
        public IActionResult Create()
        {
            ViewData["RoleFk"] = new SelectList(_context.UserRoles, "RoleId", "RoleId");
            return View();
        }

        // POST: C14/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccessFaliedCount,Claims,ConcurrencyStamp,Email,EmailConfirmed,Id,LockoutEnabled,LockoutEnd,Logins,NormalizedEmail,NormalizedUserName,PasswordHash,PhoneNumber,PhoneNumberConfirmed,Roles,SecurityStamp,TwoFactorEnabled,UserName")] IdentityRole user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleFk"] = new SelectList(_context.UserRoles, "RoleId", "RoleId", user.Id);
            return View(user);
        }

        // GET: C14/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleFk"] = new SelectList(_context.UserRoles, "RoleId", "RoleId", user.Id);
            return View(user);
        }

        // POST: C14/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AccessFaliedCount,Claims,ConcurrencyStamp,Email,EmailConfirmed,Id,LockoutEnabled,LockoutEnd,Logins,NormalizedEmail,NormalizedUserName,PasswordHash,PhoneNumber,PhoneNumberConfirmed,Roles,SecurityStamp,TwoFactorEnabled,UserName")] IdentityRole user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            ViewData["RoleFk"] = new SelectList(_context.UserRoles, "RoleId", "RoleId", user.Id);
            return View(user);
        }

        // GET: C14/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(c => c.Id)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: C14/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
