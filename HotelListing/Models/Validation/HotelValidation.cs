using FluentValidation;
using HotelListing.Properties;

namespace HotelListing.Models.Validation
{
    public class HotelValidation : AbstractValidator<CreatHotelDTO>
    {
        public HotelValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(string.Format(Resource.VALIDATION_NOT_EMPTY, "Ten"))
                .MaximumLength(150).WithMessage(string.Format(Resource.VALIDATION_MAX_LENGTH, "Ten"))
                .MinimumLength(2).WithMessage(string.Format(Resource.VALIDATION_MIN_LENGTH, " Ten "));
            RuleFor(x => x.Address).NotEmpty().WithMessage(string.Format(Resource.VALIDATION_NOT_EMPTY, "Địa chỉ "))
                .MinimumLength(2).WithMessage(string.Format(Resource.VALIDATION_MIN_LENGTH, "Địa chỉ "))
                .MaximumLength(250).WithMessage(string.Format(Resource.VALIDATION_MAX_LENGTH, " Địa chỉ "));
        }
    }
}
