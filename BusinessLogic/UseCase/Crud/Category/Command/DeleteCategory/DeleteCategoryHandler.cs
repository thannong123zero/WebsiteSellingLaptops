using AutoMapper;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Category.Command.DeleteCategory
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryRequest, IActionResult>
    {
        private readonly ICategoryQueryRepository _categoryQueryRepository;
        private readonly ICategoryCommandRepository _categoryCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteCategoryHandler(ICategoryQueryRepository categoryQueryRepository,
            ICategoryCommandRepository categoryCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _categoryQueryRepository = categoryQueryRepository;
            _categoryCommandRepository = categoryCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(DeleteCategoryRequest request, CancellationToken cancellationToken)
        {
            var categoryToDelete = _categoryQueryRepository.Find(p => p.Id == request.Id).FirstOrDefault();
            if (categoryToDelete == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            _categoryCommandRepository.SoftDelete(categoryToDelete);

            await _unitOfWork.SaveChangesAsync();

            return new StatusCodeResult(200);
        }
    }
}
