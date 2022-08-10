using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.UpdateManufacturing
{
    internal class UpdateManufacturingValidation : BaseRequestValidator<UpdateManufacturingRequest>
    {
        public UpdateManufacturingValidation()
        {
            RuleFor(s => s.MadeIn).NotEmpty().WithMessage("MadeIn is not empty!");
        }
    }
}
