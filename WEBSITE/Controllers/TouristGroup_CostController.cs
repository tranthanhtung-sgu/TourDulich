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
    public class TouristGroup_CostController : Controller
    {
        private BUS_CostCategory _busCostCategory = new BUS_CostCategory();
        private BUS_TouristGroup _busTouristGroup = new BUS_TouristGroup();
        private BUS_TouristGroup_Cost _busTouristGroup_Cost = new BUS_TouristGroup_Cost();

        public TouristGroup_CostController()
        {
        }

        // GET: TouristGroup_Cost/Create
        public IActionResult Create(int id)
        {
            var touristGroup = _busTouristGroup.GetById(id);
            TouristGroup_Cost touristGroup_Cost = new TouristGroup_Cost();
            touristGroup_Cost.TouristGroupId = touristGroup.Id;
            ViewData["CostCategoryId"] = new SelectList(_busCostCategory.GetAll(), "Id", "Name");
            return View(touristGroup_Cost);
        }

        // POST: TouristGroup_Cost/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TouristGroupId,Money,CostCategoryId")] TouristGroup_Cost touristGroup_Cost)
        {
            // check if the cost is already in the group
            var cost = _busCostCategory.Context.TouristGroup_Costs.Any(x => x.TouristGroupId == touristGroup_Cost.TouristGroupId && x.CostCategoryId == touristGroup_Cost.CostCategoryId);
            if (cost)
            {
                ModelState.AddModelError("", "This cost is already in the group");
            }
            else {
                if (ModelState.IsValid)
                {
                    _busTouristGroup_Cost.Insert(touristGroup_Cost);
                    await _busTouristGroup_Cost.SaveAsync();
                    return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Cost.TouristGroupId });
                }
            }
            ViewData["CostCategoryId"] = new SelectList(_busCostCategory.GetAll(), "Id", "Name", touristGroup_Cost.CostCategoryId);
            return View(touristGroup_Cost);
        }

        // GET: TouristGroup_Cost/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup_Cost = _busTouristGroup_Cost.GetById(id);
            if (touristGroup_Cost == null)
            {
                return NotFound();
            }
            ViewData["CostCategoryId"] = new SelectList(_busCostCategory.GetAll(), "Id", "Name", touristGroup_Cost.CostCategoryId);
            return View(touristGroup_Cost);
        }

        // POST: TouristGroup_Cost/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TouristGroupId,Money,CostCategoryId")] TouristGroup_Cost touristGroup_Cost)
        {
            if (id != touristGroup_Cost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _busTouristGroup_Cost.Update(touristGroup_Cost);
                    await _busTouristGroup_Cost.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TouristGroup_CostExists(touristGroup_Cost.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Cost.TouristGroupId });
            }
            return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Cost.TouristGroupId });
        }

        // GET: TouristGroup_Cost/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup_Cost = _busTouristGroup_Cost.GetById(id);
            if (touristGroup_Cost == null)
            {
                return NotFound();
            }

            return View(touristGroup_Cost);
        }

        // POST: TouristGroup_Cost/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var touristGroup_Cost = _busTouristGroup_Cost.GetById(id);
            _busTouristGroup_Cost.Delete(touristGroup_Cost.Id);
            await _busTouristGroup_Cost.SaveAsync();
            return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Cost.TouristGroupId });
        }

        private bool TouristGroup_CostExists(int id)
        {
            return _busTouristGroup_Cost.context.TouristGroup_Costs.Any(e => e.Id == id);
        }
        private float UpdateRevenue(TouristGroup _currentTouristGroup)
        {
            int numberCustomer = _currentTouristGroup.TouristGroup_Customers.Count;
            float TienBanVe = 0;
            // get price in prices of tour depend on the time of tourist group
            if(_currentTouristGroup.Tour != null)
            {
                foreach (var item in _currentTouristGroup.Tour.Prices)
                {
                    if (item.StartDate.Date <= _currentTouristGroup.StartDate.Date && item.EndDate.Date >= _currentTouristGroup.EndDate.Date)
                    {
                        TienBanVe = item.Money * numberCustomer;
                    }
                }
            }
            return TienBanVe - _currentTouristGroup.TouristGroup_Costs.Sum(x => x.Money);
        }
    }
}
