using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Wallet.Command.DeleteWallet
{
    public class DeleteWalletRequest : IRequest<IActionResult>
    {
        public Guid Id { get; set; }
    }
}
