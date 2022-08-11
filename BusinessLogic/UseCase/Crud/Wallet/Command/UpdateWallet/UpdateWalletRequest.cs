using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Wallet.Command.UpdateWallet
{
    public class UpdateWalletRequest : IRequest<WalletViewModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Money { get; set; }
        public string? Description { get; set; }
    }
}
