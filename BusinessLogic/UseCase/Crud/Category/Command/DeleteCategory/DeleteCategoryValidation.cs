using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.DeleteCategory
{
    public class DeleteCategoryValidation : BaseRequestValidator<DeleteCategoryRequest>
    {
        public DeleteCategoryValidation()
        {
            RuleFor(s => s.Id).NotEmpty().WithMessage("Id not Empty!");
        }
    }
}
