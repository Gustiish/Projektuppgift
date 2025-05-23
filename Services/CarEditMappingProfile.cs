using AutoMapper;
using Projektuppgift.Models;
using Projektuppgift.ViewModels;

namespace Projektuppgift.Services
{
    public class CarEditMappingProfile : Profile
    {
        public CarEditMappingProfile()
        {
            CreateMap<CarEditViewModel, CarRental>()
                .ForMember(c => c.Brand, opt => opt.MapFrom(opt => opt.Brand))
                .ForMember(c => c.Model, opt => opt.MapFrom(opt => opt.Model))
                .ForMember(c => c.Image, opt => opt.MapFrom(opt => opt.Images))
                .ForMember(c => c.Id, opt => opt.MapFrom(opt => opt.Id))
                .ForMember(c => c.IsBooked, opt => opt.MapFrom(opt => opt.IsBooked))
                .ForMember(c => c.CustomerOrderId, opt => opt.MapFrom(opt => opt.CustomerOrderId))
                .ReverseMap();
        }
    }
}
