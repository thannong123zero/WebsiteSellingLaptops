using DataAccess.IRepositories;
using DataAccess.IRepositories.IUserRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.User.Command.DeteleUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, IActionResult>
    {
        public readonly IUserCommandRepository _userCommandRepository;
        public readonly IUserQueryRepository _userQueryRepository;
        public readonly IUnitOfWork _unitOfWork;
        public DeleteUserHandler(IUserQueryRepository userQueryRepository,
            IUserCommandRepository userCommandRepository,
            IUnitOfWork unitOfWork)
        {
            _userCommandRepository = userCommandRepository;
            _userQueryRepository = userQueryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var User = _userQueryRepository.Find(p => p.Id == request.Id,withDeleteFlag:false).FirstOrDefault();
            
            if (User == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            User.IsActive = true;
            _userCommandRepository.Update(User);
            await _unitOfWork.SaveChangesAsync();

            return new StatusCodeResult(200);
        }
    }
}
