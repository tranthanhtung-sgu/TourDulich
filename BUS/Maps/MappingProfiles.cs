using AutoMapper;
using BUS.Dtos;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Maps
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Tour, DTO_Tour>()
                .ForMember(d => d.LoaiHinhDuLich, o => o.MapFrom(s => s.Category.CategoryName))
                // get price with date between startDate and endDate
                .ForMember(d => d.GiaTour, o => o.MapFrom(s => s.Prices.FirstOrDefault(p => p.StartDate.Date <= DateTime.Now.Date && p.EndDate.Date >= DateTime.Now.Date).Money));
            CreateMap<Price, DTO_Price>();
            CreateMap<TourDetail, DTO_ChiTietTour>()
                .ForMember(d => d.LocationName, o => o.MapFrom(s => s.Location.LocationName));
            CreateMap<Location, DTO_Location>();
            CreateMap<TouristGroup, DTO_TouristGroup>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Tour.TenGoi))
                .ForMember(d => d.StartDate, o => o.MapFrom(s => s.StartDate.Date))
                .ForMember(d => d.EndDate, o => o.MapFrom(s => s.EndDate.Date))
                .ForMember(d => d.TourGuide, o => o.MapFrom(s => s.TouristGroup_Staffs.FirstOrDefault(p => p.Duty == "TourGuide").Staff.Name))
                .ForMember(d => d.NumberOfTourist, o => o.MapFrom(s => s.TouristGroup_Staffs.Count() + s.TouristGroup_Customers.Count()));
        }
    }
}
