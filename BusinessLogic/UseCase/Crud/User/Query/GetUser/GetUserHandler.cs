using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IUserRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.User.Query.GetUser
{
    public class GetUserHandler : IRequestHandler<GetUserRequest, UserViewModel>
    {
        private readonly IUserQueryRepository _userQueryRepository;
        private readonly IMapper _mapper;
        public GetUserHandler(IUserQueryRepository userQueryRepository,
        IMapper mapper)
        {
            _userQueryRepository = userQueryRepository;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userQueryRepository.Find(c => c.Id == request.Id,withDeleteFlag: false).FirstOrDefault();
            if (user == null)
            {
                throw new DomainException("User Id does not exist!");
            }
            return _mapper.Map<UserViewModel>(user);
        }
    }
}
