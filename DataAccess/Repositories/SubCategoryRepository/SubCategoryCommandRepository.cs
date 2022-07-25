using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ISubCategoryRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.SubCategoryRepository
{
    public class SubCategoryCommandRepository : GeneralCommandRepository<SubCategoryModel>, ISubCategoryCommandRepository
    {
        public SubCategoryCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
