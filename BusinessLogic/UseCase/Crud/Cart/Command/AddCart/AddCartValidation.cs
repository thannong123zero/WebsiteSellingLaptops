using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Command.AddCart
{
    public class AddCartValidation :BaseRequestValidator<AddCartRequest>
    {
        public AddCartValidation()
        {
            RuleFor(s => s.TotalMoney).NotEmpty().WithMessage("TotalMoney is not empty!");
            RuleFor(s => s.CustomerId).NotNull().WithMessage("CustomerId is not empty!");
        }
}
}
