using FluentValidationWithMVC.Models;
using FluentValidationWithMVC.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationWithMVC.Logic
{
    public class UsersLogic
    {
        protected UserValidator Validator { get; set; }

        public UsersLogic()
        {
            Validator = new UserValidator();
        }

        public Result<User> Create(User user)
        {
            var validationResult = Validator.Validate(user);

            if(validationResult.IsValid == false)
            {
                return Result.Failure<User>(validationResult.Errors);
            }

            //zapis danych do bazy

            return Result.Ok<User>(user);
        }
    }
}