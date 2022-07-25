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
        public AddCategoryHandler(ICategoryCommandRepository categoryCommandRepository, IUnitOfWork unitOfWork)
        {
            _categoryCommandRepository = categoryCommandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CategoryViewModel> Handle(AddCategoryRequest request, CancellationToken cancellationToken)
        {
            var Id = Guid.NewGuid();
            //CategoryModel model = new CategoryModel()
            //{
            //    Id = Id,
            //    CategoryName = request.Name
            //};
            //_categoryCommandRepository.Add(model);
            //await _unitOfWork.SaveChangesAsync();

            CategoryViewModel categoryViewModel = new CategoryViewModel()
            {
                Id = Id,
                Name = request.Name
            };

            return categoryViewModel;
        }
    }
}
