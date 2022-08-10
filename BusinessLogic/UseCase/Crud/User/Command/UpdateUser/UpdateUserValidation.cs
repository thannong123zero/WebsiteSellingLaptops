using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Command.UpdateUser
{
    public class UpdateUserValidation : BaseRequestValidator<UpdateUserRequest>
    {
        public UpdateUserValidation()
        {
            RuleFor(s => s.CitizenId).NotEmpty().WithMessage("CitizenId is not empty!")
                .Matches(@"^\+*\d{10,15}$")
                    .WithMessage("CitizenId is invalid!");

            RuleFor(s => s.FullName).NotNull().WithMessage("FullName is not empty!");
            RuleFor(s => s.Email).NotNull().WithMessage("Email is not empty!")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                    .WithMessage("Email format not match");

            RuleFor(s => s.Address).NotNull().WithMessage("Address is not empty");
            RuleFor(s => s.BirthDay).NotNull().WithMessage("BrithDay is not empty");
            RuleFor(s => s.PhoneNumber).NotNull().WithMessage("PhoneNumber is not empty!")
                .Matches(@"^\+*\d{10,15}$")
                    .WithMessage("Phone number is invalid!");

        }
    }
}
