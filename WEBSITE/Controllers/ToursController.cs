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
using BUS.Dtos;

namespace WEBSITE.Controllers
{
    public class ToursController : Controller
    {
        private BUS_Tour bTour = new BUS_Tour();
        private BUS_Price bprice = new BUS_Price();
        private BUS_Category bCategory = new BUS_Category();
        private List<Price> prices = new List<Price>();

        public ToursController()
        {
        }

        // GET: Tours
        public IActionResult Index()
        {
            var tours = bTour.GetAll();
            return View(tours);
        }

        // GET: Tours/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour = bTour.GetTourById((int)id);
            if (tour == null)
            {
                return NotFound();
            }

            return View(tour);
        }

        // GET: Tours/Create
        public IActionResult Create()
        {
            var categories = bCategory.GetAll();
            ViewData["CategoryId"] = new SelectList(categories, "Id", "CategoryName");
            return View();
        }

        // POST: Tours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TourId,TenGoi,MoTa,CategoryId")] Tour tour)
        {
           if (ModelState.IsValid)
           {
                bTour.Insert(tour);
               await bTour.context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
           }
           var categories = bCategory.GetAll();
           ViewData["CategoryId"] = new SelectList(categories, "Id", "CategoryName", tour.CategoryId);
           return View(tour);
        }

        // GET: Tours/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           if (id == null)
           {
               return NotFound();
           }

           var tour = await bTour.FindAsync(id);
            var categories = bCategory.GetAll();
           if (tour == null)
           {
               return NotFound();
           }
           ViewData["CategoryId"] = new SelectList(categories, "Id", "CategoryName", tour.CategoryId);
           return View(tour);
        }

        // POST: Tours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TourId,TenGoi,MoTa,CategoryId")] Tour tour)
        {
           if (id != tour.TourId)
           {
               return NotFound();
           }

           if (ModelState.IsValid)
           {
               try
               {
                   bTour.Update(tour);
                   await bTour.context.SaveChangesAsync();
               }
               catch (DbUpdateConcurrencyException)
               {
                   if (!TourExists(tour.TourId))
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
           ViewData["CategoryId"] = new SelectList(bCategory.GetAll(), "Id", "CategoryName", tour.CategoryId);
           return View(tour);
        }

        private bool TourExists(int tourId)
        {
              return bTour.context.Tours.Any(e => e.TourId == tourId);
        }

        // GET: Tours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
           if (id == null)
           {
               return NotFound();
           }

           var tour = await bTour.FindAsync(id);
           if (tour == null)
           {
               return NotFound();
           }

           return View(tour);
        }

        // POST: Tours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           var tour = await bTour.FindAsync(id);
           bTour.Delete(tour.TourId);
           return RedirectToAction(nameof(Index));
        }
    }
}
