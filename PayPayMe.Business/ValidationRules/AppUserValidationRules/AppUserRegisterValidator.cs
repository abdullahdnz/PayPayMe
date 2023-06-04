using FluentValidation;
using PayPayMe.DTO.DTOs.AppUserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPayMe.Business.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("This field cannot be blank.");
            RuleFor(x => x.Lastname).NotEmpty().WithMessage("This field cannot be blank.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("This field cannot be blank.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("This field cannot be blank.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("This field cannot be blank.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("This field cannot be blank.");

            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Maximum 30 characters allowed.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Minimum 3 characters allowed.");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter valid email");

            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Passwords don't match");
        }
    }
}
