using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.UpdateCategory
{
    public class UpdateCategoryValidation : BaseRequestValidator<UpdateCategoryRequest>
    {
        public UpdateCategoryValidation()
        {
            RuleFor(s => s.Id).NotEmpty().WithMessage("Category Id not empty!");
            RuleFor(s => s.Name).NotEmpty().WithMessage("Category Name not empty!");
        }
    }
}
