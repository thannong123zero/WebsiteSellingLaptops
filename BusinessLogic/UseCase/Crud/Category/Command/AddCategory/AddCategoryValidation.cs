using BusinessLogic.Extentions.BaseRequestValidators;
using BusinessLogic.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.AddCategory
{
    public class AddCategoryValidation : BaseRequestValidator<AddCategoryRequest>
    {
        public AddCategoryValidation()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Category Name not empty Nguyen Hoang Tai");
        }
    }
}
