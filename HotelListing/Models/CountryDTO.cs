using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreatCountryDTO
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
    public class UpdateCountryDTO : CreatCountryDTO
    {
        public IList<CreatHotelDTO> Hotels { get; set; }
    }
    public class CountryDTO : CreatCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

    }
}
