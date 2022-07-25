using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ICategoryRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.CategoryRepository
{
    public class CategoryCommandRepository : GeneralCommandRepository<CategoryModel>, ICategoryCommandRepository
    {
        public CategoryCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
