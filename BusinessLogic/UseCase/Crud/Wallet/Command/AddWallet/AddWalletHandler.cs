using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IWalletRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Wallet.Command.AddWallet
{
    public class AddWalletHandler : IRequestHandler<AddWalletRequest, WalletViewModel>
    {
        private readonly IWalletCommandRepository _walletCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddWalletHandler(IWalletCommandRepository walletCommandRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _walletCommandRepository = walletCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<WalletViewModel> Handle(AddWalletRequest request, CancellationToken cancellationToken)
        {
            var wallet = _mapper.Map<WalletModel>(request);
            _walletCommandRepository.Add(wallet);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<WalletViewModel>(wallet);
        }
    }
}
