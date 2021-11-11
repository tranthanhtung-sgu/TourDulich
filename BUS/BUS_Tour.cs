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

        public Tour UpdateTour (Tour tour)
        {
            var result = Update(tour);
            return result;
        }

        public bool DeleteTour (int tourId)
        {
            var result = Delete(tourId);
            return result;
        }

    }
}
