using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Wallet.Query.GetWallet
{
    public class GetWalletRequest : IRequest<WalletViewModel>
    {
        public Guid Id { get; set; }
    }
}
