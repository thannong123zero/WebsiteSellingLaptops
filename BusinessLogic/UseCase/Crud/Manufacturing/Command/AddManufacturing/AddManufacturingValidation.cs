﻿using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.AddManufacturing
{
    public class AddManufacturingValidation : BaseRequestValidator<AddManufacturingRequest>
    {
        public AddManufacturingValidation()
        {
            RuleFor(s => s.MadeIn).NotEmpty().WithMessage("MadeIn is not empty!");
        }
    }
}
