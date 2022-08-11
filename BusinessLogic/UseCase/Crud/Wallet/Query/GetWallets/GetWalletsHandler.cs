using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IWalletRepository;
using MediatR;

namespace BusinessLogic.UseCase.Crud.Wallet.Query.GetWallets
{
    public class GetWalletsHandler : IRequestHandler<GetWalletsRequest, List<WalletViewModel>>
    {
        private readonly IWalletQueryRepository _walletQueryRepository;
        private readonly IMapper _mapper;
        public GetWalletsHandler(IWalletQueryRepository walletQueryRepository, IMapper mapper)
        {
            _walletQueryRepository = walletQueryRepository;
            _mapper = mapper;
        }
        public async Task<List<WalletViewModel>> Handle(GetWalletsRequest request, CancellationToken cancellationToken)
        {
            var listWallet = await _walletQueryRepository.GetAllAsync();

            List<WalletViewModel> result = new List<WalletViewModel>();

            listWallet.ForEach(s => result.Add(_mapper.Map<WalletViewModel>(s)));

            return result;
        }
    }
}
