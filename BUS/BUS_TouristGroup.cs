using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TouristGroup : GenericRepository<TouristGroup>
    {
        public BUS_TouristGroup()
        {

        }

        public new List<TouristGroup> GetAll()
        {
            List<TouristGroup> touristGroups = _context.TouristGroups
                    .Include(t => t.Tour)
                    .Include(t => t.TouristGroup_Customers).ThenInclude(t => t.Customer)
                    .Include(t => t.TouristGroup_Staffs).ThenInclude(t => t.Staff)
                    .Include(t => t.TouristGroup_Costs).ThenInclude(t=>t.CostCategory)
                    .ToList();
            return touristGroups;
        }

        public void InsertTouristGroup(TouristGroup currentTouristGroup)
        {
            var touristGroup_Staffs = currentTouristGroup.TouristGroup_Staffs;
            var touristGroup_Customers = currentTouristGroup.TouristGroup_Customers;
            var costs = currentTouristGroup.TouristGroup_Costs;
            currentTouristGroup.TouristGroup_Staffs = null;
            currentTouristGroup.TouristGroup_Customers = null;
            currentTouristGroup.TouristGroup_Costs = null;
            _context.TouristGroups.Add(currentTouristGroup);
            _context.SaveChanges();

            // Add TouristGroup_Staffs
            foreach (var item in touristGroup_Staffs)
            {
                var touristGroup_Staff = new TouristGroup_Staff()
                {
                    TouristGroupId = currentTouristGroup.Id,
                    StaffId = item.StaffId,
                    Duty = item.Duty
                };

                _context.TouristGroup_Staffs.Add(touristGroup_Staff);
            }

            // Add TouristGroup_Customers
            foreach (var item in touristGroup_Customers)
            {
                var touristGroup_Customer = new TouristGroup_Customer()
                {
                    TouristGroupId = currentTouristGroup.Id,
                    CustomerId = item.CustomerId
                };

                _context.TouristGroup_Customers.Add(touristGroup_Customer);
            }
            // Add TouristGroup_Costs
            foreach (var item in costs)
            {
                var touristGroup_Cost = new TouristGroup_Cost()
                {
                    TouristGroupId = currentTouristGroup.Id,
                    CostCategoryId = item.CostCategoryId,
                    Money = item.Money
                };

                _context.TouristGroup_Costs.Add(touristGroup_Cost);
            }
            Save();

        }

        public TouristGroup FindById(int? id)
        {
            return _context.TouristGroups
                        .Include(x => x.TouristGroup_Staffs).ThenInclude(y => y.Staff)
                        .Include(x => x.TouristGroup_Customers).ThenInclude(y => y.Customer)
                        .FirstOrDefault(x => x.Id == id);
                                           
        }

        public void UpdateTouristGroup(TouristGroup currentTouristGroup)
        {
            var touristGroup_Staffs = currentTouristGroup.TouristGroup_Staffs;
            var touristGroup_Customers = currentTouristGroup.TouristGroup_Customers;
            var costs = currentTouristGroup.TouristGroup_Costs;
            // remove all touristGroup_Staffs and touristGroup_Customers of TouristGroup in database
            var touristGroup_StaffsInDatabase = _context.TouristGroup_Staffs.Where(t => t.TouristGroupId == currentTouristGroup.Id).ToList();
            var touristGroup_CustomersInDatabase = _context.TouristGroup_Customers.Where(t => t.TouristGroupId == currentTouristGroup.Id).ToList();
            _context.TouristGroup_Staffs.RemoveRange(touristGroup_StaffsInDatabase);
            _context.TouristGroup_Customers.RemoveRange(touristGroup_CustomersInDatabase);
            // remove all costs of TouristGroup in database
            var costsInDatabase = _context.TouristGroup_Costs.Where(t => t.TouristGroupId == currentTouristGroup.Id).ToList();
            _context.TouristGroup_Costs.RemoveRange(costsInDatabase);
            // update TouristGroup
            currentTouristGroup.TouristGroup_Staffs = null;
            currentTouristGroup.TouristGroup_Customers = null;
            currentTouristGroup.TouristGroup_Costs = null;
            _context.Entry(currentTouristGroup).State = EntityState.Modified;
            Save();
            foreach (var item in touristGroup_Staffs)
            {
                var touristGroup_Staff = new TouristGroup_Staff()
                {
                    TouristGroupId = currentTouristGroup.Id,
                    StaffId = item.StaffId,
                    Duty = item.Duty
                };

                _context.TouristGroup_Staffs.Add(touristGroup_Staff);
            }

            // Add TouristGroup_Customers
            foreach (var item in touristGroup_Customers)
            {
                var touristGroup_Customer = new TouristGroup_Customer()
                {
                    TouristGroupId = currentTouristGroup.Id,
                    CustomerId = item.CustomerId
                };

                _context.TouristGroup_Customers.Add(touristGroup_Customer);
            }
            // Add TouristGroup_Costs
            foreach (var item in costs)
            {
                var touristGroup_Cost = new TouristGroup_Cost()
                {
                    TouristGroupId = currentTouristGroup.Id,
                    CostCategoryId = item.CostCategoryId,
                    Money = item.Money
                };

                _context.TouristGroup_Costs.Add(touristGroup_Cost);
            }
            Save();
        }
    }
}
