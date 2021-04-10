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
    public class CranialsController : Controller
    {
        private readonly mummiesdbContext _context;

        public CranialsController(mummiesdbContext context)
        {
            _context = context;
        }

        // GET: Cranials
        public async Task<IActionResult> Index()
        {
            var mummiesdbContext = _context.Cranial.Include(c => c.BurialFkNavigation);
            return View(await mummiesdbContext.ToListAsync());
        }

        // GET: Cranials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cranial = await _context.Cranial
                .Include(c => c.BurialFkNavigation)
                .FirstOrDefaultAsync(m => m.CranialId == id);
            if (cranial == null)
            {
                return NotFound();
            }

            return View(cranial);
        }

        // GET: Cranials/Create
        public IActionResult Create()
        {
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId");
            return View();
        }

        // POST: Cranials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CranialId,BurialFk,BurialLocation,SampleNumber,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,BurialPositioningNorthSouthNumber,BurialPositioningNorthSouthDirection,BurialPositioningEastWestNumber,BurialPositioningEastWestDirection,BurialNumber,BurialDepth,BurialSubPlotDirection,BurialArtifactDescription,BuriedWithArtifacts,GilesGender,BodyGender")] Cranial cranial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cranial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", cranial.BurialFk);
            return View(cranial);
        }

        // GET: Cranials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cranial = await _context.Cranial.FindAsync(id);
            if (cranial == null)
            {
                return NotFound();
            }
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", cranial.BurialFk);
            return View(cranial);
        }

        // POST: Cranials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CranialId,BurialFk,BurialLocation,SampleNumber,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,BurialPositioningNorthSouthNumber,BurialPositioningNorthSouthDirection,BurialPositioningEastWestNumber,BurialPositioningEastWestDirection,BurialNumber,BurialDepth,BurialSubPlotDirection,BurialArtifactDescription,BuriedWithArtifacts,GilesGender,BodyGender")] Cranial cranial)
        {
            if (id != cranial.CranialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cranial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CranialExists(cranial.CranialId))
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
            ViewData["BurialFk"] = new SelectList(_context.Burial, "BurialId", "BurialId", cranial.BurialFk);
            return View(cranial);
        }

        // GET: Cranials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cranial = await _context.Cranial
                .Include(c => c.BurialFkNavigation)
                .FirstOrDefaultAsync(m => m.CranialId == id);
            if (cranial == null)
            {
                return NotFound();
            }

            return View(cranial);
        }

        // POST: Cranials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cranial = await _context.Cranial.FindAsync(id);
            _context.Cranial.Remove(cranial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CranialExists(int id)
        {
            return _context.Cranial.Any(e => e.CranialId == id);
        }
    }
}
