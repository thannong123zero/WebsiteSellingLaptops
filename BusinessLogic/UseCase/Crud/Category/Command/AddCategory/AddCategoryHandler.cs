using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
            CategoryModel model = new CategoryModel()
            {
                CategoryName = request.CategoryName
            };
            _categoryCommandRepository.Add(model);
            await _unitOfWork.SaveChangesAsync();

            var categoryViewModel = _mapper.Map<CategoryViewModel>(model);

            return categoryViewModel;
        }
    }
}
