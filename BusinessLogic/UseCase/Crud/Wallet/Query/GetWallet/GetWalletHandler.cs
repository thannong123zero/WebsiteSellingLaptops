using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IWalletRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Wallet.Query.GetWallet
{
    public class GetWalletHandler : IRequestHandler<GetWalletRequest, WalletViewModel>
    {
        private readonly IWalletQueryRepository _walletQueryRepository;
        private readonly IMapper _mapper;
        public GetWalletHandler(IWalletQueryRepository walletQueryRepository,IMapper mapper)
        {
            _walletQueryRepository = walletQueryRepository;
            _mapper = mapper;
        }
        public async Task<WalletViewModel> Handle(GetWalletRequest request, CancellationToken cancellationToken)
        {
            var wallet = await _walletQueryRepository.GetByIdAsync(request.Id);
            if(wallet == null)
            {
                throw new DomainException("WalletId does not exist!");
            }
            return _mapper.Map<WalletViewModel>(wallet);
        }
    }
}
