using AutoMapper;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICartRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Command.RestoreCart
{
    public class RestoreCartHandler : IRequestHandler<RestoreCartRequest, IActionResult>
    {
        private readonly ICartCommandRepository _cartCommandRepository;
        private readonly ICartQueryRepository _cartQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RestoreCartHandler(ICartCommandRepository cartCommandRepository,
            ICartQueryRepository cartQueryRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _cartCommandRepository = cartCommandRepository;
            _cartQueryRepository = cartQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<IActionResult> Handle(RestoreCartRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
