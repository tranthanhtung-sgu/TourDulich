using AutoMapper;
using BUS.Dtos;
using BUS.Maps;
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
    public class BUS_Tour : GenericRepository<Tour>, IGenericRepository<Tour>
    {
        public BUS_Tour()
        {
            
        }

        public new List<Tour> GetAll()
        {
            List<Tour> tours = _context.Tours.Include(x=>x.Category)
                                                .Include(y=>y.Prices)
                                                .Include(t=>t.TourDetails).ThenInclude(l=>l.Location)
                                                .ToList();
            return tours;
        }
        public Tour GetTourById (int tourId)
        {
            var tour = GetById(tourId);
            return tour;
        }
        
        public Tour AddTour (Tour tour)
        {
            var result = Insert(tour);
            return result;
        }

        public Tour UpdateTour (Tour currentTour)
        {
            var currentDetails = currentTour.TourDetails;
            //remove all tour details of current tour
            var tourDetails = _context.TourDetails.Where(x => x.TourId == currentTour.TourId).ToList();
            _context.TourDetails.RemoveRange(tourDetails);
            //remove all prices of current tour
            var prices = _context.Prices.Where(x => x.TourId == currentTour.TourId).ToList();
            _context.Prices.RemoveRange(prices);
            Save();
            
            // add new tour details
            var tourUpdate = new Tour();
            tourUpdate = currentTour;
            foreach (var item in currentDetails)
            {
                var tourDetail = new TourDetail() {
                    LocationId = item.LocationId,
                    TourId = currentTour.TourId,
                    Serial = item.Serial
                };
                _context.TourDetails.Add(tourDetail);
            }   
            tourUpdate.TourDetails = new List<TourDetail>();
            foreach (var item in currentTour.Prices)
            {
                var price = new Price()
                {
                    TourId = currentTour.TourId,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    Money = item.Money
                };
                _context.Prices.Add(price);
            }     
            tourUpdate.Prices = new List<Price>();
            var result = Update(tourUpdate);
            Save();
            return result;    
        }

        public bool DeleteTour (int tourId)
        {
            var result = Delete(tourId);
            return result;
        }

        public Tour InsertTour(Tour currentTour)
        {
            var currentDetails = currentTour.TourDetails;
            // add new tour details
            var tourUpdate = new Tour();
            tourUpdate = currentTour;
            tourUpdate.TourDetails = new List<TourDetail>();
            var result = Insert(tourUpdate);
            foreach (var item in currentTour.TourDetails)
            {
                var tourDetail = new TourDetail() {
                    LocationId = item.LocationId,
                    TourId = currentTour.TourId,
                    Serial = item.Serial
                };
                tourUpdate.TourDetails.Add(tourDetail);
            }        
            Save();
            return result;  
        }
    }
}
