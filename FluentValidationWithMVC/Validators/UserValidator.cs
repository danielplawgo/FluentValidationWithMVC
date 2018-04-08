using FluentValidation;
using FluentValidationWithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationWithMVC.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .EmailAddress();

            RuleFor(u => u.Nip)
                .NotEmpty()
                .When(u => u.CreateInvoice);
        }
    }
}