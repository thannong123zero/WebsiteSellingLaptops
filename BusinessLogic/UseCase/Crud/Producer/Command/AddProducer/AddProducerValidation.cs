﻿using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Producer.Command.AddProducer
{
    public class AddProducerValidation : BaseRequestValidator<AddProducerRequest>
    {
        public AddProducerValidation()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is not empty!");
            RuleFor(s => s.Address).NotEmpty().WithMessage("Address is not empty!");
            RuleFor(s => s.NumberPhone).NotNull().WithMessage("PhoneNumber is not empty!")
                .Matches(@"^\+*\d{10,15}$")
                    .WithMessage("Phone number is invalid!");
        }
    }
}
