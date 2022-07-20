using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.ViewModel;
using FluentValidation;
namespace BusinessLogic.UseCase.Crud.User.Command.AddUser
{
    public class AddUserValidation : ValidatorDescriptor<UserViewModel>
    {
        public AddUserValidation(IEnumerable<IValidationRule> rules) : base(rules)
        {
        }
    }
}
