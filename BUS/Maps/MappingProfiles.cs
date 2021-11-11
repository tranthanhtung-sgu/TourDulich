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
                // mapping 
                .ForMember(d => d.GiaTour, o => o.MapFrom(s => s.Prices.Select(x => x.Money).FirstOrDefault()));
            CreateMap<Price, DTO_Price>();
            CreateMap<TourDetail, DTO_ChiTietTour>()
                .ForMember(d => d.LocationName, o => o.MapFrom(s => s.Location.LocationName));
        }
    }
}
