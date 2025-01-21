using eCommerce.Core.DTO;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator() 
    {
        RuleFor(temp => temp.Email)
            .NotEmpty().WithMessage("Email ID can not blank.")
            .EmailAddress().WithMessage("Invalid Email-ID.");

        RuleFor(temp => temp.Password)
            .NotEmpty().WithMessage("Password can not blank.")
            .Length(5).WithMessage("Password can not be less than 5 characters");

        RuleFor(temp => temp.PersonName)
            .NotEmpty().WithMessage("Please enter Person Name.");

        RuleFor(temp => temp.Gender)
            //.NotEmpty().WithMessage("Please enter Gender.")
            .IsInEnum().WithMessage("Invalid Option, Options could be: Male, Female & Others only.");
    }
}
