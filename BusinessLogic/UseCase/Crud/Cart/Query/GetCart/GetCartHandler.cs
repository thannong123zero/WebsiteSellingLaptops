﻿using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICartRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Query.GetCart
{
    public class GetCartHandler : IRequestHandler<GetCartRequest, CartViewModel>
    {
        private readonly ICartCommandRepository _cartCommandRepository;
        private readonly ICartQueryRepository _cartQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCartHandler(ICartCommandRepository cartCommandRepository,
            ICartQueryRepository cartQueryRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _cartCommandRepository = cartCommandRepository;
            _cartQueryRepository = cartQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<CartViewModel> Handle(GetCartRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
