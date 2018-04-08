using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationWithMVC.Models
{
    public class User
    {
        public string Email { get; set; }

        public bool CreateInvoice { get; set; }

        public string Nip { get; set; }
    }
}