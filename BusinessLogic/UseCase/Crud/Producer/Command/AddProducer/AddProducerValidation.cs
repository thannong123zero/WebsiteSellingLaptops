using BusinessLogic.Extentions.BaseRequestValidators;
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
            RuleFor(s => s.Name).NotEmpty().WithMessage("Category Name not empty!");
        }
    }
}
