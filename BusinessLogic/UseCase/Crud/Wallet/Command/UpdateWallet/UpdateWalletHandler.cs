using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IWalletRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Wallet.Command.UpdateWallet
{
    public class UpdateWalletHandler : IRequestHandler<UpdateWalletRequest, WalletViewModel>
    {
        private readonly IWalletCommandRepository _walletCommandRepository;
        private readonly IWalletQueryRepository _walletQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateWalletHandler(IWalletCommandRepository walletCommandRepository,
            IWalletQueryRepository walletQueryRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _walletCommandRepository = walletCommandRepository;
            _walletQueryRepository = walletQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<WalletViewModel> Handle(UpdateWalletRequest request, CancellationToken cancellationToken)
        {
            var wallet = await _walletQueryRepository.GetByIdAsync(request.Id);
            if(wallet == null)
            {
                throw new DomainException("WalletId does not exist!");
            }
            wallet.UpdateAt = DateTime.Now;
            _mapper.Map(request, wallet);

            _walletCommandRepository.Update(wallet);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<WalletViewModel>(wallet);
        }
    }
}
