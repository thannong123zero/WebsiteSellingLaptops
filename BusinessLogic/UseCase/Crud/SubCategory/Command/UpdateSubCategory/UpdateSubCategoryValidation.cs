using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.SubCategory.Command.UpdateSubCategory
{
    public class UpdateSubCategoryValidation : BaseRequestValidator<UpdateSubCategoryRequest>
    {
        public UpdateSubCategoryValidation()
        {
            RuleFor(s => s.CategoryId).NotEmpty().WithMessage("CategoryId not empty!");
            RuleFor(s => s.Name).NotEmpty().WithMessage("SubCategory Name not empty!");
        }
    }
}
