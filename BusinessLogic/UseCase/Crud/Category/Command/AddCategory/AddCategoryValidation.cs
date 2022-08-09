using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;

namespace BusinessLogic.UseCase.Crud.Category.Command.AddCategory
{
    public class AddCategoryValidation : BaseRequestValidator<AddCategoryRequest>
    {
        public AddCategoryValidation()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Category Name not empty!");
        }
    }
}
