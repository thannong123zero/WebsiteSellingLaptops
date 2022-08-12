using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.WareHouse.Command.AddWareHouse
{
    public class AddWareHouseValidation : BaseRequestValidator<AddWareHouseRequest>
    {
        public AddWareHouseValidation()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is not empty!");
            RuleFor(s => s.Address).NotEmpty().WithMessage("Address is not empty!");
        }
    }
}
