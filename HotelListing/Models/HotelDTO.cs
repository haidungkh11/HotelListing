using HotelListing.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Models
{
    public class CreatHotelDTO
    { 
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public double Rating { get; set; }

        public int CountryId { get; set; }
       
    }
    public class UpdateHotelDTO : CreatHotelDTO
    {

    }
    public class HotelDTO : CreatHotelDTO
    {
        public int Id { get; set; }

        public CountryDTO Country { get; set; }
        
    }
}
