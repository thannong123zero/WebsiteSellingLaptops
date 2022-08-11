using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Wallet.Command.AddWallet
{
    public class AddWalletValidation : BaseRequestValidator<AddWalletRequest>
    {
        public AddWalletValidation()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is not empty!");
            RuleFor(s => s.Money).NotEmpty().WithMessage("Money is not empty!");
        }
    }
}
