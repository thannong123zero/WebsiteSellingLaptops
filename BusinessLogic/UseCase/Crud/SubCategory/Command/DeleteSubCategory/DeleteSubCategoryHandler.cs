using AutoMapper;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ISubCategoryRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.SubCategory.Command.DeleteSubCategory
{
    public class DeleteSubCategoryHandler : IRequestHandler<DeleteSubCategoryRequest, IActionResult>
    {
        private readonly ISubCategoryCommandRepository _subCategoryCommandRepository;
        private readonly ISubCategoryQueryRepository _subCategoryQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteSubCategoryHandler(ISubCategoryCommandRepository subCategoryCommandRepository,
            ISubCategoryQueryRepository subCategoryQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _subCategoryCommandRepository = subCategoryCommandRepository;
            _subCategoryQueryRepository = subCategoryQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(DeleteSubCategoryRequest request, CancellationToken cancellationToken)
        {
            var categoryToDelete = _subCategoryQueryRepository.Find(p => p.Id == request.Id).FirstOrDefault();
            if (categoryToDelete == null)
            {
                throw new DomainException("SubCategory Id does not exist!");
            }
            _subCategoryCommandRepository.SoftDelete(categoryToDelete);

            await _unitOfWork.SaveChangesAsync();

            return new StatusCodeResult(200);
        }
    }
}
