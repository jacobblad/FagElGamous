﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FagElGamous.Models;

namespace FagElGamous
{
    public class BurialsController : Controller
    {
        private readonly mummiesdbContext _context;

        public BurialsController(mummiesdbContext context)
        {
            _context = context;
        }

        // GET: Burials
        public async Task<IActionResult> Index()
        {
            return View(await _context.Burial.ToListAsync());
        }

        // GET: Burials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burial
                .FirstOrDefaultAsync(m => m.BurialId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // GET: Burials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Burials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BurialId,BurialLocation,BurialLocationNs,BurialLocationEw,LowPairNs,HighPairNs,LowPairEw,HighPairEw,BurialSubplot,BurialDepth,SouthToHead,SouthToFeet,WestToHead,WestToFeet,BurialSituation,LengthOfRemains,BurialNumber,SampleNumber,GenderGe,GeFunctionTotal,GenderBodyCol,BurialGenderMethod,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,ArtifactsDescription,HairColorCode,HairColorDescription,PreservationIndex,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,DescriptionOfTaken,ArtifactFound,EstimateAge,AgeCode,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,YearFound,MonthFound,DayFound,HeadDirection,YearOnSkull,MonthOnSkull,DateOnSkull,FieldBook,FieldBookPageNumber,InitialsOfDataEntryExpert,InitialsOfDataEntryCheker,ByuSample,BodyAnalysis,SkullAtMagazine,PostcraniaAtMagazine,RackAndShelf,ToBeConfirmed,SkullTrama,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLocation,MetopicStructure,ButtonOsteoma,PostcraniaTrauma,OsteologyUnknownComment,TemporalMandibularJoinOsteoarthritis,LinearHypoplasiaEnamel,Tomb,AreaHillBurials,BurialPreservation,BurialWrapingCode,BurialAdultChild,Burialagemethod,BurialSampleTaken,Goods,Cluster,FaceBundle,OsteologyNotes")] Burial burial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burial);
        }

        // GET: Burials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burial.FindAsync(id);
            if (burial == null)
            {
                return NotFound();
            }
            return View(burial);
        }

        // POST: Burials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BurialId,BurialLocation,BurialLocationNs,BurialLocationEw,LowPairNs,HighPairNs,LowPairEw,HighPairEw,BurialSubplot,BurialDepth,SouthToHead,SouthToFeet,WestToHead,WestToFeet,BurialSituation,LengthOfRemains,BurialNumber,SampleNumber,GenderGe,GeFunctionTotal,GenderBodyCol,BurialGenderMethod,BasilarSuture,VentralArc,SubpubicAngle,SciaticNotch,PubicBone,PreaurSulcus,MedialIpRamus,DorsalPitting,ForemanMagnum,FemurHead,HumerusHead,Osteophytosis,PubicSymphysis,FemurLength,HumerusLength,TibiaLength,Robust,SupraorbitalRidges,OrbitEdge,ParietalBossing,Gonian,NuchalCrest,ZygomaticCrest,CranialSuture,MaximumCranialLength,MaximumCranialBreadth,BasionBregmaHeight,BasionNasion,BasionProsthionLength,BizygomaticDiameter,NasionProsthion,MaximumNasalBreadth,InterorbitalBreadth,ArtifactsDescription,HairColorCode,HairColorDescription,PreservationIndex,HairTaken,SoftTissueTaken,BoneTaken,ToothTaken,TextileTaken,DescriptionOfTaken,ArtifactFound,EstimateAge,AgeCode,EstimateLivingStature,ToothAttrition,ToothEruption,PathologyAnomalies,EpiphysealUnion,YearFound,MonthFound,DayFound,HeadDirection,YearOnSkull,MonthOnSkull,DateOnSkull,FieldBook,FieldBookPageNumber,InitialsOfDataEntryExpert,InitialsOfDataEntryCheker,ByuSample,BodyAnalysis,SkullAtMagazine,PostcraniaAtMagazine,RackAndShelf,ToBeConfirmed,SkullTrama,CribraOrbitala,PoroticHyperostosis,PoroticHyperostosisLocation,MetopicStructure,ButtonOsteoma,PostcraniaTrauma,OsteologyUnknownComment,TemporalMandibularJoinOsteoarthritis,LinearHypoplasiaEnamel,Tomb,AreaHillBurials,BurialPreservation,BurialWrapingCode,BurialAdultChild,Burialagemethod,BurialSampleTaken,Goods,Cluster,FaceBundle,OsteologyNotes")] Burial burial)
        {
            if (id != burial.BurialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BurialExists(burial.BurialId))
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
            return View(burial);
        }

        // GET: Burials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.Burial
                .FirstOrDefaultAsync(m => m.BurialId == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // POST: Burials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var burial = await _context.Burial.FindAsync(id);
            _context.Burial.Remove(burial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurialExists(int id)
        {
            return _context.Burial.Any(e => e.BurialId == id);
        }
    }
}
