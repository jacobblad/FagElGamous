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
    public class SamplesController : Controller
    {
        private readonly mummiesdbContext _context;

        public SamplesController(mummiesdbContext context)
        {
            _context = context;
        }

        // GET: Samples
        public async Task<IActionResult> Index()
        {
            var mummiesdbContext = _context.Sample.Include(s => s.BurialFkNavigation);
            return View(await mummiesdbContext.ToListAsync());
        }

        // GET: Samples/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample
                .Include(s => s.BurialFkNavigation)
                .FirstOrDefaultAsync(m => m.SampleId == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        // GET: Samples/Create
        public IActionResult Create()
        {
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId");
            return View();
        }

        // POST: Samples/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SampleId,BurialFk,BurialLocation,Rack,Bag,Low,High,NS,Low1,High1,EW,Area,Burial,Date,PreviouslySampled,Notes,Initials")] Sample sample)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sample);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", sample.BurialFk);
            return View(sample);
        }

        // GET: Samples/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample.FindAsync(id);
            if (sample == null)
            {
                return NotFound();
            }
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", sample.BurialFk);
            return View(sample);
        }

        // POST: Samples/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SampleId,BurialFk,BurialLocation,Rack,Bag,Low,High,NS,Low1,High1,EW,Area,Burial,Date,PreviouslySampled,Notes,Initials")] Sample sample)
        {
            if (id != sample.SampleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sample);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SampleExists(sample.SampleId))
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
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", sample.BurialFk);
            return View(sample);
        }

        // GET: Samples/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample
                .Include(s => s.BurialFkNavigation)
                .FirstOrDefaultAsync(m => m.SampleId == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        // POST: Samples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sample = await _context.Sample.FindAsync(id);
            _context.Sample.Remove(sample);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SampleExists(int id)
        {
            return _context.Sample.Any(e => e.SampleId == id);
        }
    }
}
