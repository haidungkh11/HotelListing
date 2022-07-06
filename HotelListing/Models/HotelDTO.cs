using HotelListing.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Models
{
    public class CreatHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Address name is too long")]
        public string Address { get; set; }
        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        
        [Required]
        public int CountryId { get; set; }
       
    }
    public class HotelDTO : CreatCountryDTO
    {
        public int Id { get; set; }

        public CountryDTO Country { get; set; }
        
    }
}
