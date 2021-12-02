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
    public class TourDetailController : Controller
    {
        private BUS_TourDeltail bTourDetail = new BUS_TourDeltail();
        private BUS_Tour bTour = new BUS_Tour();
        private BUS_Location bLocation = new BUS_Location();

        public TourDetailController()
        {
        }

        // GET: TourDetail/Create
        public IActionResult Create(int id)
        {
            Tour tour = bTour.GetTourById(id);
            var tourDetail = new TourDetail();
            tourDetail.TourId = tour.TourId;

            ViewData["LocationId"] = new SelectList(bLocation.GetAll(), "Id", "LocationName");
            return View(tourDetail);
        }

        // POST: TourDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TourId,LocationId,Serial")] TourDetail tourDetail)
        {
            if (ModelState.IsValid)
            {
                bTourDetail.Insert(tourDetail);
                await bTour.SaveAsync();
                return RedirectToAction("Details", "Tours", new { id = tourDetail.TourId });
            }
            return RedirectToAction("Details", "Tours", new { id = tourDetail.TourId });
        }

        // GET: TourDetail/Edit/5
        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var tourDetail = bTourDetail.GetById(id);
            Tour tour = bTour.GetTourById(tourDetail.TourId);
            if (tourDetail == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(bLocation.GetAll(), "Id", "LocationName");
            ViewData["TourId"] = tour;
            return View(tourDetail);
        }

        // POST: TourDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourId,LocationId,Serial")] TourDetail tourDetail)
        {
            if (id != tourDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bTourDetail.Update(tourDetail);
                    await bTour.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TourDetailExists(tourDetail.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Tours", new { id = tourDetail.TourId });
            }
            return RedirectToAction("Details", "Tours", new { id = tourDetail.TourId });
        }

        // GET: TourDetail/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourDetail = bTourDetail.GetById(id);
            if (tourDetail == null)
            {
                return NotFound();
            }

            return View(tourDetail);
        }

        // POST: TourDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tourDetail = bTourDetail.GetById(id);
            bTourDetail.Delete(tourDetail.Id);
            await bTour.SaveAsync();
            return RedirectToAction("Details", "Tours", new { id = tourDetail.TourId });
        }

        private bool TourDetailExists(int id)
        {
            return bTour.context.TourDetails.Any(e => e.Id == id);
        }
    }
}
