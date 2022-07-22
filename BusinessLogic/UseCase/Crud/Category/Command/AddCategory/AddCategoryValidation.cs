using BusinessLogic.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.AddCategory
{
    public class AddCategoryValidation : ValidatorDescriptor<CategoryViewModel>
    {
        public AddCategoryValidation(IEnumerable<IValidationRule> rules) : base(rules)
        {
        }
    }
}
