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
        public ActionResult DrawChart(int id)
        {
            //get list touristGroup has Tourid equals with id
            var listTouristGroup = bTouristGroup.GetAll().Where(x => x.TourId == id).ToList();
            if (listTouristGroup == null)
            {
                return NotFound();
            }
            return PartialView("_DrawChart", listTouristGroup);
        }
    }
}
