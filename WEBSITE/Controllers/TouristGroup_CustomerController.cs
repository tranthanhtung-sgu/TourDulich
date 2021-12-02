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
    public class TouristGroup_CustomerController : Controller
    {
        private BUS_TouristGroup bTouristGroup = new BUS_TouristGroup();
        private BUS_TouristGroup_Customer bGroupCustomer= new BUS_TouristGroup_Customer();
        private BUS_Customer bCustomer = new BUS_Customer();

        public TouristGroup_CustomerController()
        {
        }

        // GET: TouristGroup_Customer/Create
        public IActionResult Create(int id)
        {
            var touristGroup = bTouristGroup.GetById(id);
            TouristGroup_Customer touristGroup_Customer = new TouristGroup_Customer();
            touristGroup_Customer.TouristGroupId = touristGroup.Id;
            ViewData["CustomerId"] = new SelectList(bCustomer.GetAll(), "Id", "FullName");
            return View(touristGroup_Customer);
        }

        // POST: TouristGroup_Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TouristGroupId,CustomerId")] TouristGroup_Customer touristGroup_Customer)
        {

            // check if the customer is already in the group
            var groupCustomer = await bGroupCustomer.context.TouristGroup_Customers.AnyAsync(x => x.CustomerId == touristGroup_Customer.CustomerId && x.TouristGroupId == touristGroup_Customer.TouristGroupId);
            if (groupCustomer)
            {
                ModelState.AddModelError("", "The customer is already in the group");    
            } else {
                if (ModelState.IsValid)
                {
                    bGroupCustomer.Insert(touristGroup_Customer);
                    await bGroupCustomer.SaveAsync();
                    return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Customer.TouristGroupId });
                }
            }
            ViewData["CustomerId"] = new SelectList(bCustomer.GetAll(), "Id", "FullName");
            return View(touristGroup_Customer);
        }

        // GET: TouristGroup_Customer/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup_Customer = bGroupCustomer.GetById(id);
            if (touristGroup_Customer == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(bCustomer.GetAll(), "Id", "FullName", touristGroup_Customer.CustomerId);
            return View(touristGroup_Customer);
        }

        // POST: TouristGroup_Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TouristGroupId,CustomerId")] TouristGroup_Customer touristGroup_Customer)
        {
            if (id != touristGroup_Customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bGroupCustomer.Update(touristGroup_Customer);
                    await bGroupCustomer.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TouristGroup_CustomerExists(touristGroup_Customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Customer.TouristGroupId });
            }
            return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Customer.TouristGroupId });
        }

        // GET: TouristGroup_Customer/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup_Customer = bGroupCustomer.GetById(id);
            if (touristGroup_Customer == null)
            {
                return NotFound();
            }

            return View(touristGroup_Customer);
        }

        // POST: TouristGroup_Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var touristGroup_Customer = bGroupCustomer.GetById(id);
            bGroupCustomer.Delete(touristGroup_Customer.Id);
            await bGroupCustomer.SaveAsync();
            return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Customer.TouristGroupId });
        }

        private bool TouristGroup_CustomerExists(int id)
        {
            return bGroupCustomer.context.TouristGroup_Customers.Any(e => e.Id == id);
        }
    }
}
