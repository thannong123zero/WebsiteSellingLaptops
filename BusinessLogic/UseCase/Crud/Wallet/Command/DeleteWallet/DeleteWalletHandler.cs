using AutoMapper;
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

namespace BusinessLogic.UseCase.Crud.Wallet.Command.DeleteWallet
{
    public class DeleteWalletHandler : IRequestHandler<DeleteWalletRequest, IActionResult>
    {
        private readonly IWalletCommandRepository _walletCommandRepository;
        private readonly IWalletQueryRepository _walletQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteWalletHandler(IWalletCommandRepository walletCommandRepository,
            IWalletQueryRepository walletQueryRepository,
            IUnitOfWork unitOfWork)
        {
            _walletCommandRepository = walletCommandRepository;
            _walletQueryRepository = walletQueryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Handle(DeleteWalletRequest request, CancellationToken cancellationToken)
        {
            var wallet = _walletQueryRepository.Find(s => s.Id == request.Id).FirstOrDefault();
            if (wallet == null)
            {
                throw new DomainException("WalletId does not exist!");
            }
            _walletCommandRepository.SoftDelete(wallet);
             await _unitOfWork.SaveChangesAsync();
            return new StatusCodeResult(200);
        }
    }
}
