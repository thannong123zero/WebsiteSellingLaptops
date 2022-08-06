using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.RestoreCategory
{
    internal class RestoreCategoryValidation : BaseRequestValidator<RestoreCategoryRequest>
    {
        public RestoreCategoryValidation()
        {
            RuleFor(s => s.Id).NotEmpty().WithMessage("Id not Empty!");
        }
    }
}
