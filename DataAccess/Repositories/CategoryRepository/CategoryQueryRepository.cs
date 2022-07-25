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
    public class CategoryQueryRepository : GeneralQueryRepository<CategoryModel>, ICategoryQueryRepository
    {
        public CategoryQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
