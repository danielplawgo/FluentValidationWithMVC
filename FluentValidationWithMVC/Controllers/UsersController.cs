using FluentValidationWithMVC.Logic;
using FluentValidationWithMVC.Models;
using FluentValidationWithMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentValidationWithMVC.Controllers
{
    public class UsersController : Controller
    {
        protected UsersLogic UsersLogic { get; set; }

        public UsersController()
        {
            UsersLogic = new UsersLogic();
        }

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewModel()
        {
            return View(new CreateUserViewModel());
        }

        [HttpPost]
        public ActionResult ViewModel(CreateUserViewModel viewModel)
        {
            if(ModelState.IsValid == false)
            {
                return View(viewModel);
            }

            return Content("Dodano");
        }

        [HttpGet]
        public ActionResult Model()
        {
            return View(new CreateWithModelUserViewModel());
        }

        [HttpPost]
        public ActionResult Model(CreateWithModelUserViewModel viewModel)
        {
            if(ModelState.IsValid == false)
            {
                return View(viewModel);
            }

            var user = new User() //I normally use the automapper to map model <-> viewmodel
            {
                Email = viewModel.Email,
                CreateInvoice = viewModel.CreateInvoice,
                Nip = viewModel.Nip
            };

            var result = UsersLogic.Create(user);

            if(result.Success == false)
            {
                result.AddErrorToModelState(ModelState);
                return View(viewModel);
            }

            return Content("Dodano");
        }

        
    }
}