using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ISubCategoryRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Repositories.SubCategoryRepository
{
    public class SubCategoryQueryRepository : GeneralQueryRepository<SubCategoryModel>, ISubCategoryQueryRepository
    {
        public SubCategoryQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}