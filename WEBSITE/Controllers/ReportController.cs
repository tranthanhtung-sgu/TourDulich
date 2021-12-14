using BUS;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Models;

namespace WEBSITE.Controllers
{
    public class ReportController : Controller
    {
        private BUS_TouristGroup bTouristGroup = new BUS_TouristGroup();
        private BUS_Tour bTour = new BUS_Tour();
        public IActionResult Index()
        {
            ReportViewModel reportViewModel = new ReportViewModel
            {
                TouristGroups = bTouristGroup.GetAll(),
                Tours = bTour.GetAll()
            };
            return View(reportViewModel);
        }
        
        [HttpGet]
        public ActionResult DrawChart(Filter data)
        {
            if (data.TourId == 0)
            {
                return Json(new { success = false, message = "Vui lòng chọn tour" });
            }
            //get list touristGroup has Tourid equals with id and has start date in data.Year
            var listTouristGroup = bTouristGroup.GetAll();
            var listTouristGroupHasTourId = listTouristGroup.Where(x => x.TourId == data.TourId && x.StartDate.Year == data.Year).ToList();
            if (listTouristGroupHasTourId == null)
            {
                return NotFound();
            }
            return PartialView("_DrawChart", listTouristGroupHasTourId);
        }
    }
}
