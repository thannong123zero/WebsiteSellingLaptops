using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using System;

namespace BusinessLogic.UseCase.Crud.Category.Command.AddCategory
{
    public class AddCategoryHandler : IRequestHandler<AddCategoryRequest, CategoryViewModel>
    {
        private readonly ICategoryCommandRepository _categoryCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddCategoryHandler(ICategoryCommandRepository categoryCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _categoryCommandRepository = categoryCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CategoryViewModel> Handle(AddCategoryRequest request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<CategoryModel>(request);
             _categoryCommandRepository.Add(model);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CategoryViewModel>(model);
        }
    }
}
