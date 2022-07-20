using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ISubCategoryRepository;
using DataAccess.Repositories.GeneralRepository;
using System;

namespace DataAccess.Repositories.SubCategoryRepository
{
    public class SubCategoryQueryRepository : GeneralQueryRepository<SubCategoryModel>, ISubCategoryQueryRepository
    {
        public SubCategoryQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}