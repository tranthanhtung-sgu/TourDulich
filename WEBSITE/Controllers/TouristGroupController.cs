using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Entities;
using BUS;

namespace WEBSITE.Controllers
{
    public class TouristGroupController : Controller
    {
        private BUS_TouristGroup bTouristGroup = new BUS_TouristGroup();
        private BUS_Tour bTour = new BUS_Tour();

        public TouristGroupController()
        {
        }

        // GET: TouristGroup
        public IActionResult Index()
        {
            var touristGroup = bTouristGroup.GetAll();
            return View(touristGroup);
        }

        // GET: TouristGroup/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup = bTouristGroup.FindById(id);
            if (touristGroup == null)
            {
                return NotFound();
            }

            return View(touristGroup);
        }

        // GET: TouristGroup/Create
        public IActionResult Create()
        {
            ViewData["TourId"] = new SelectList(bTour.GetAll(), "TourId", "TenGoi");
            return View();
        }

        // POST: TouristGroup/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TourId,StartDate,EndDate,Hotel,Description")] TouristGroup touristGroup)
        {
            if (ModelState.IsValid)
            {
                bTouristGroup.Insert(touristGroup);
                await bTouristGroup.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TourId"] = new SelectList(bTour.GetAll(), "TourId", "TenGoi", touristGroup.TourId);
            return View(touristGroup);
        }

        // GET: TouristGroup/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup = bTouristGroup.GetById(id);
            if (touristGroup == null)
            {
                return NotFound();
            }
            ViewData["TourId"] = new SelectList(bTour.GetAll(), "TourId", "TenGoi", touristGroup.TourId);
            return View(touristGroup);
        }

        // POST: TouristGroup/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourId,StartDate,EndDate,Hotel,Description")] TouristGroup touristGroup)
        {
            if (id != touristGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bTouristGroup.Update(touristGroup);
                    await bTouristGroup.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TouristGroupExists(touristGroup.Id))
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
            ViewData["TourId"] = new SelectList(bTour.GetAll(), "TourId", "TenGoi", touristGroup.TourId);
            return View(touristGroup);
        }

        // GET: TouristGroup/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup = bTouristGroup.GetById(id);
            if (touristGroup == null)
            {
                return NotFound();
            }

            return View(touristGroup);
        }

        // POST: TouristGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var touristGroup = bTouristGroup.GetById(id);
            bTouristGroup.Delete(touristGroup.Id);
            await bTouristGroup.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TouristGroupExists(int id)
        {
            return bTour.context.TouristGroups.Any(e => e.Id == id);
        }
    }
}
