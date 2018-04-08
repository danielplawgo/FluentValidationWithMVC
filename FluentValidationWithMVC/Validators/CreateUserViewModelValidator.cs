using FluentValidation;
using FluentValidationWithMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationWithMVC.Validators
{
    public class CreateUserViewModelValidator : AbstractValidator<CreateUserViewModel>
    {
        public CreateUserViewModelValidator()
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