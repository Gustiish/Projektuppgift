using AutoMapper;
using Projektuppgift.Models;
using Projektuppgift.ViewModels;

namespace Projektuppgift.Services
{
    public class CarCreateMappingProfile : Profile
    {
        public CarCreateMappingProfile()
        {
            CreateMap<CarCreateViewModel, CarRental>()
                .ForMember(s => s.Brand, opt => opt.MapFrom(s => s.Brand))
                .ForMember(s => s.Model, opt => opt.MapFrom(s => s.Model))
                .ForMember(s => s.Images, opt => opt.MapFrom(s => s.Images))
                .ReverseMap();
        }

        


    }
}
