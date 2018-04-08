using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationWithMVC.ViewModels
{
    public class CreateWithModelUserViewModel
    {
        public string Email { get; set; }

        public bool CreateInvoice { get; set; }

        public string Nip { get; set; }
    }
}