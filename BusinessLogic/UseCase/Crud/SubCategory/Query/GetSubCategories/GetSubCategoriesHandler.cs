using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ISubCategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.SubCategory.Query.GetSubCategories
{
    public class GetSubCategoriesHandler : IRequestHandler<GetSubCategoriesRequest, List<SubCategoryViewModel>>
    {
        private readonly ISubCategoryQueryRepository _subCategoryQueryRepository;
        private readonly IMapper _mapper;
        public GetSubCategoriesHandler(ISubCategoryQueryRepository subCategoryQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _subCategoryQueryRepository = subCategoryQueryRepository;
            _mapper = mapper;
        }
        public async Task<List<SubCategoryViewModel>> Handle(GetSubCategoriesRequest request, CancellationToken cancellationToken)
        {
            var listCategories = await _subCategoryQueryRepository.GetAllAsync();

            List<SubCategoryViewModel> result = new List<SubCategoryViewModel>();

            listCategories.ForEach(s => result.Add(_mapper.Map<SubCategoryViewModel>(s)));
            return result;
        }
    }
}
