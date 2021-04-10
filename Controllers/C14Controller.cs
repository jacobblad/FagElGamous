using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FagElGamous.Models;

namespace FagElGamous
{
    public class C14Controller : Controller
    {
        private readonly mummiesdbContext _context;

        public C14Controller(mummiesdbContext context)
        {
            _context = context;
        }

        // GET: C14
        public async Task<IActionResult> Index()
        {
            var mummiesdbContext = _context.C14.Include(c => c.BurialFkNavigation);
            return View(await mummiesdbContext.ToListAsync());
        }

        // GET: C14/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var c14 = await _context.C14
                .Include(c => c.BurialFkNavigation)
                .FirstOrDefaultAsync(m => m.C14Id == id);
            if (c14 == null)
            {
                return NotFound();
            }

            return View(c14);
        }

        // GET: C14/Create
        public IActionResult Create()
        {
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId");
            return View();
        }

        // POST: C14/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("C14Id,BurialFk,BurialLocation,Rack,NS,Column6,EW,Column8,Square,Area,Burial,Rack1,Tube,Description,SizeMl,Foci,C14Sample2017,Location,QuestionS,Column20,Conventional14cAgeBp,Column14cCalendarDate,Calibrated95CalendarDateMax,Calibrated95CalendarDateMin,Calibrated95CalendarDateSpan,Calibrated95CalendarDateAvg,Category,Notes")] C14 c14)
        {
            if (ModelState.IsValid)
            {
                _context.Add(c14);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", c14.BurialFk);
            return View(c14);
        }

        // GET: C14/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var c14 = await _context.C14.FindAsync(id);
            if (c14 == null)
            {
                return NotFound();
            }
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", c14.BurialFk);
            return View(c14);
        }

        // POST: C14/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("C14Id,BurialFk,BurialLocation,Rack,NS,Column6,EW,Column8,Square,Area,Burial,Rack1,Tube,Description,SizeMl,Foci,C14Sample2017,Location,QuestionS,Column20,Conventional14cAgeBp,Column14cCalendarDate,Calibrated95CalendarDateMax,Calibrated95CalendarDateMin,Calibrated95CalendarDateSpan,Calibrated95CalendarDateAvg,Category,Notes")] C14 c14)
        {
            if (id != c14.C14Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(c14);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!C14Exists(c14.C14Id))
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
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", c14.BurialFk);
            return View(c14);
        }

        // GET: C14/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var c14 = await _context.C14
                .Include(c => c.BurialFkNavigation)
                .FirstOrDefaultAsync(m => m.C14Id == id);
            if (c14 == null)
            {
                return NotFound();
            }

            return View(c14);
        }

        // POST: C14/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var c14 = await _context.C14.FindAsync(id);
            _context.C14.Remove(c14);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool C14Exists(int id)
        {
            return _context.C14.Any(e => e.C14Id == id);
        }
    }
}
