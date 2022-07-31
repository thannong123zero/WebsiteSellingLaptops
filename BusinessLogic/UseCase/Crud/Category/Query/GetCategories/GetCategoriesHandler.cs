using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Query.GetCategories
{
    public class GetCategoriesHandler : IRequestHandler<GetCategoriesRequest, List<CategoryViewModel>>
    {
        private readonly ICategoryQueryRepository _categoryQueryRepository;
        private readonly IMapper _mapper;
        public GetCategoriesHandler(ICategoryQueryRepository categoryQueryRepository,
IMapper mapper)
        {
            _categoryQueryRepository = categoryQueryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryViewModel>> Handle(GetCategoriesRequest request, CancellationToken cancellationToken)
        {
            var listCategories = await _categoryQueryRepository.GetAllAsync();

            List<CategoryViewModel> result = new List<CategoryViewModel>();

            listCategories.ForEach(s => result.Add(_mapper.Map<CategoryViewModel>(s)));

            return result;
        }
    }
}
