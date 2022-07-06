using AutoMapper;
using HotelListing.Data;
using HotelListing.Models;

namespace HotelListing.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreatCountryDTO>().ReverseMap();
            CreateMap<Country, HotelDTO>().ReverseMap();
            CreateMap<Country, CreatHotelDTO>().ReverseMap();
        }
    }
}
