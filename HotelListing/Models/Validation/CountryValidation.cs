using FluentValidation;
using global::HotelListing.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models.Validation
 {
    public class CountryValidation : AbstractValidator<CreatCountryDTO>
    {
       public CountryValidation()
       {
                RuleFor(x => x.Name).NotEmpty().WithMessage(string.Format(Resource.VALIDATION_NOT_EMPTY, "Tên"))
                    .MaximumLength(200).WithMessage(string.Format(Resource.VALIDATION_MAX_LENGTH, "Ten", "200"))
                    .MinimumLength(2).WithMessage(string.Format(Resource.VALIDATION_MIN_LENGTH, "Ten", "2"));

                RuleFor(x => x.ShortName).NotEmpty().WithMessage(string.Format(Resource.VALIDATION_NOT_EMPTY, "Tên"))
                    .MaximumLength(200).WithMessage(string.Format(Resource.VALIDATION_MAX_LENGTH, "Tên", "200"))
                    .MinimumLength(2).WithMessage(string.Format(Resource.VALIDATION_MIN_LENGTH, "Tên", "2"));
       }
    }
}


