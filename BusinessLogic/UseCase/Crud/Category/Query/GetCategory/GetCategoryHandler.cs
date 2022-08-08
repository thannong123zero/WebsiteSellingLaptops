using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Category.Query.GetCategory
{
    public class GetCategoryHandler : IRequestHandler<GetCategoryRequest, CategoryViewModel>
    {
        private readonly ICategoryQueryRepository _categoryQueryRepository;
        private readonly IMapper _mapper;
        public GetCategoryHandler(ICategoryQueryRepository categoryQueryRepository,
        IMapper mapper)
        {
            _categoryQueryRepository = categoryQueryRepository;
            _mapper = mapper;
        }
        public async Task<CategoryViewModel> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
        {
            CategoryModel Category =  _categoryQueryRepository.Find(c => c.Id == request.Id, s => s.Include(x => x.SubCategories)).FirstOrDefault();
            if (Category == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            return _mapper.Map<CategoryViewModel>(Category);
        }
    }
}
