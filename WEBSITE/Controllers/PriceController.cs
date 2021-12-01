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
    public class PriceController : Controller
    {
        private BUS_Price bPrice = new BUS_Price();
        private BUS_Tour bTour = new BUS_Tour();
        public PriceController()
        {
            
        }

        // GET: Price
        public IActionResult Index()
        {
            return View();
        }

        // GET: Price/Create
        public IActionResult Create()
        {
            ViewData["TourId"] = new SelectList(bTour.GetAll(), "TourId", "TenGoi");
            return View();
        }

        // POST: Price/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TourId,Money,StartDate,EndDate")] Price price)
        {
            if (ModelState.IsValid)
            {
                bPrice.Insert(price);
                await bTour.context.SaveChangesAsync();
                return RedirectToAction("Details", "Tours", new { id = price.TourId });
            }
            ViewData["TourId"] = new SelectList(bTour.GetAll(), "TourId", "TourId", price.TourId);
            //redirect to tour detail with id is tourid
            return RedirectToAction("Details", "Tours", new { id = price.TourId });
        }

        // GET: Price/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await bPrice.FindAsync(id);
            if (price == null)
            {
                return NotFound();
            }
            ViewData["TourId"] = price.Tour;
            return View(price);
        }

        // POST: Price/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourId,Money,StartDate,EndDate")] Price price)
        {
            if (id != price.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bPrice.Update(price);
                    await bPrice.context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PriceExists(price.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Tours", new { id = price.TourId });
            }
            ViewData["TourId"] = new SelectList(bTour.GetAll(), "TourId", "TourId", price.TourId);
            return RedirectToAction("Details", "Tours", new { id = price.TourId });
        }

        // GET: Price/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await bPrice.FindAsync(id);
            if (price == null)
            {
                return NotFound();
            }

            return View(price);
        }

        // POST: Price/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var price = await bPrice.FindAsync(id);
            bPrice.Delete(price.Id);
            await bPrice.context.SaveChangesAsync();
            return RedirectToAction("Details", "Tours", new { id = price.TourId });
        }

        private bool PriceExists(int id)
        {
            return bPrice.context.Prices.Any(e => e.Id == id);
        }
    }
}
