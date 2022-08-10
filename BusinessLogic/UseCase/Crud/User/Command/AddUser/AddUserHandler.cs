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

namespace BusinessLogic.UseCase.Crud.User.Command.AddUser
{
    public class AddUserHandler : IRequestHandler<AddUserRequest, UserViewModel>
    {
        private readonly IUserCommandRepository _userCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddUserHandler(IUserCommandRepository userCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _userCommandRepository = userCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<UserViewModel> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            UserModel user = _mapper.Map<UserModel>(request);
            user.PasswordHash = request.Password;
            _userCommandRepository.Add(user);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<UserViewModel>(user);
        }
    }
}
