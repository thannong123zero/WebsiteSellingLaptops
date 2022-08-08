using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.ISubCategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.SubCategory.Query.GetSubCategory
{
    public class GetSubCategoryHandler : IRequestHandler<GetSubCategoryRequest, SubCategoryViewModel>
    {
        private readonly ISubCategoryQueryRepository _subCategoryQueryRepository;
        private readonly IMapper _mapper;
        public GetSubCategoryHandler(ISubCategoryQueryRepository subCategoryQueryRepository,
            IMapper mapper)
        {
            _subCategoryQueryRepository = subCategoryQueryRepository;
            _mapper = mapper;
        }
        public async Task<SubCategoryViewModel> Handle(GetSubCategoryRequest request, CancellationToken cancellationToken)
        {
            var subCategory = _subCategoryQueryRepository.Find(c => c.Id == request.Id).FirstOrDefault();
            if (subCategory == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            return _mapper.Map<SubCategoryViewModel>(subCategory);
        }
    }
}
