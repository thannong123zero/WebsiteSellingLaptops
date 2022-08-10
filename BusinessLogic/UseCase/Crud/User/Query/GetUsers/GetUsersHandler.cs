using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IUserRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Query.GetUsers
{
    public class GetUsersHandler : IRequestHandler<GetUsersRequest, List<UserViewModel>>
    {
        private readonly IUserQueryRepository _userQueryRepository;
        private readonly IMapper _mapper;
        public GetUsersHandler(IUserQueryRepository userQueryRepository,
        IMapper mapper)
        {
            _userQueryRepository = userQueryRepository;
            _mapper = mapper;
        }
        public async Task<List<UserViewModel>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var ListUser = await _userQueryRepository.GetAllAsync(withDeleteFlag: false);

            List<UserViewModel> result = new List<UserViewModel>();

            ListUser.ForEach(s => result.Add(_mapper.Map<UserViewModel>(s)));

            return result;
        }
    }
}
