using DataAccess.IRepositories;
using DataAccess.IRepositories.IWalletRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Wallet.Command.RestoreWallet
{
    public class RestoreWalletHandler : IRequestHandler<RestoreWalletRequest, IActionResult>
    {
        private readonly IWalletCommandRepository _walletCommandRepository;
        private readonly IWalletQueryRepository _walletQueryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RestoreWalletHandler(IWalletCommandRepository walletCommandRepository,
            IWalletQueryRepository walletQueryRepository,
            IUnitOfWork unitOfWork)
        {
            _walletCommandRepository = walletCommandRepository;
            _walletQueryRepository = walletQueryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Handle(RestoreWalletRequest request, CancellationToken cancellationToken)
        {
            var wallet = _walletQueryRepository.Find(s => s.Id == request.Id,withDeleteFlag:false).FirstOrDefault();
            if (wallet == null)
            {
                throw new DomainException("WalletId does not exist!");
            }
            _walletCommandRepository.RestoreDelete(wallet);
            await _unitOfWork.SaveChangesAsync();
            return new StatusCodeResult(200);
        }
    }
}
