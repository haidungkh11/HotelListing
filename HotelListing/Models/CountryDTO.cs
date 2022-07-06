using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreatCountryDTO
    {
      
        [Required]
        [StringLength(maximumLength:50,ErrorMessage = "Coutry name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "Short Coutry name is too long")]
        public string ShortName { get; set; }
    }
    public class CountryDTO :CreatCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

    }
}
