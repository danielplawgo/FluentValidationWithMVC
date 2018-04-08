using FluentValidation.Attributes;
using FluentValidationWithMVC.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationWithMVC.ViewModels
{
    [Validator(typeof(CreateUserViewModelValidator))]
    public class CreateUserViewModel
    {
        public string Email { get; set; }

        public bool CreateInvoice { get; set; }

        public string Nip { get; set; }
    }
}