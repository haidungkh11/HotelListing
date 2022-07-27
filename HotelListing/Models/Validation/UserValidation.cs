using FluentValidation;
using HotelListing.Properties;

namespace HotelListing.Models.Validation
{
    public class UserValidation : AbstractValidator<UserDTO>
    {
        public UserValidation()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(string.Format(Resource.VALIDATION_NOT_EMPTY, "Email"))
                .EmailAddress().WithMessage(string.Format(Resource.VALIDATION_DISPLAY, "Email"));
            RuleFor(x => x.Password).NotEmpty().WithMessage(string.Format(Resource.VALIDATION_NOT_EMPTY, "Password"));
        }
    }
}
