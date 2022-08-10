using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IUserRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.User.Command.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UserViewModel>
    {
        private readonly IUserCommandRepository _userCommandRepository;
        private readonly IUserQueryRepository _userQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateUserHandler(IUserCommandRepository userCommandRepository,
            IUserQueryRepository userQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _userCommandRepository = userCommandRepository;
            _userQueryRepository = userQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<UserViewModel> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userQueryRepository.GetByIdAsync(request.Id,withDeleteFlag:false);

            if (user == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            _mapper.Map(request, user);

            _userCommandRepository.Update(user);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<UserViewModel>(user);
        }
    }
}
