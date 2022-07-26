using BusinessLogic.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.AddCategory
{
    public class AddCategoryValidation : AbstractValidator<AddCategoryRequest>
    {
        public AddCategoryValidation()
        {
            RuleFor(s => s.CategoryName).NotEmpty().WithMessage("Property name is not empty");
        }
    }
}
