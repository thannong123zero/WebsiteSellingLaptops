using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Category.Command.UpdateCategory
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryRequest, CategoryViewModel>
    {
        private readonly ICategoryCommandRepository _categoryCommandRepository;
        private readonly ICategoryQueryRepository _categoryQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateCategoryHandler(ICategoryCommandRepository categoryCommandRepository,
            ICategoryQueryRepository categoryQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _categoryCommandRepository = categoryCommandRepository;
            _categoryQueryRepository = categoryQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CategoryViewModel> Handle(UpdateCategoryRequest request, CancellationToken cancellationToken)
        {
            var categoryUpdate = await _categoryQueryRepository.GetByIdAsync(request.Id);

            if (categoryUpdate == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            _mapper.Map(request, categoryUpdate);
            categoryUpdate.UpdateAt = DateTime.Now;
            _categoryCommandRepository.Update(categoryUpdate);
            await  _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CategoryViewModel>(categoryUpdate);
        }
    }
}
