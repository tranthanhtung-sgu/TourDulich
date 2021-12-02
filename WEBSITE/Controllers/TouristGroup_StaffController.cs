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
    public class TouristGroup_StaffController : Controller
    {
        private BUS_TouristGroup_Staff bGroupStaff = new BUS_TouristGroup_Staff();
        private BUS_TouristGroup bTouristGroup = new BUS_TouristGroup();
        private BUS_Staff bStaff = new BUS_Staff();

        public TouristGroup_StaffController()
        {
        }
        

        // GET: TouristGroup_Staff/Create
        public IActionResult Create(int id)
        {
            var touristGroup = bTouristGroup.GetById(id);
            TouristGroup_Staff touristGroup_Staff = new TouristGroup_Staff();
            touristGroup_Staff.TouristGroupId = touristGroup.Id;

            ViewData["StaffId"] = new SelectList(bStaff.GetAll(), "Id", "Name");
            return View(touristGroup_Staff);
        }

        // POST: TouristGroup_Staff/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffId,TouristGroupId,Duty")] TouristGroup_Staff touristGroup_Staff)
        {
            // check if the staff is already in the group
            var staff = bGroupStaff.context.TouristGroup_Staffs.Any(x => x.StaffId == touristGroup_Staff.StaffId && x.TouristGroupId == touristGroup_Staff.TouristGroupId);
            if (staff)
            {
                ModelState.AddModelError("", "The staff is already in the group");
            } else {
                if (ModelState.IsValid)
                {
                    bGroupStaff.Insert(touristGroup_Staff);
                    await bGroupStaff.SaveAsync();
                    return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Staff.TouristGroupId });
                }
            }
            ViewData["StaffId"] = new SelectList(bStaff.GetAll(), "Id", "Name", touristGroup_Staff.StaffId);
            return View(touristGroup_Staff);
        }

        // GET: TouristGroup_Staff/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup_Staff = bGroupStaff.GetById(id);
            if (touristGroup_Staff == null)
            {
                return NotFound();
            }
            ViewData["StaffId"] = new SelectList(bStaff.GetAll(), "Id", "Name", touristGroup_Staff.StaffId);
            return View(touristGroup_Staff);
        }

        // POST: TouristGroup_Staff/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StaffId,TouristGroupId,Duty")] TouristGroup_Staff touristGroup_Staff)
        {
            if (id != touristGroup_Staff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bGroupStaff.Update(touristGroup_Staff);
                    await bGroupStaff.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TouristGroup_StaffExists(touristGroup_Staff.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Staff.TouristGroupId });
            }
            return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Staff.TouristGroupId });
        }

        // GET: TouristGroup_Staff/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var touristGroup_Staff = bGroupStaff.GetById(id);
            if (touristGroup_Staff == null)
            {
                return NotFound();
            }

            return View(touristGroup_Staff);
        }

        // POST: TouristGroup_Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var touristGroup_Staff = bGroupStaff.GetById(id);
            bGroupStaff.Delete(touristGroup_Staff.Id);
            await bGroupStaff.SaveAsync();
            return RedirectToAction("Details", "TouristGroup", new { id = touristGroup_Staff.TouristGroupId });
        }

        private bool TouristGroup_StaffExists(int id)
        {
            return bGroupStaff.context.TouristGroup_Staffs.Any(e => e.Id == id);
        }
    }
}
