using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;

namespace BusinessLogic.UseCase.Crud.User.Command.AddUser
{
    public class AddUserValidation  : BaseRequestValidator<AddUserRequest>
    {
        public AddUserValidation()
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

            RuleFor(s => s.Password)
                .MinimumLength(8)
                .WithMessage("Password Minimum of 8 characters!");

            RuleFor(x => x.PasswordConfirmed)
                .Equal(x => x.Password)
                    .WithMessage("Confirm password does not match");

            RuleFor(x => x.PasswordConfirmed)
                .NotEmpty()
                    .WithMessage("Password is required");
        }
}
}
