using BusinessLogic.Extentions.BaseRequestValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Wallet.Command.UpdateWallet
{
    public class UpdateWalletValidation : BaseRequestValidator<UpdateWalletRequest>
    {
        public UpdateWalletValidation()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is not empty!");
            RuleFor(s => s.Money).NotEmpty().WithMessage("Money is not empty!");
        }
    }
}
