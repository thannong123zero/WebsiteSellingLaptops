using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ISubCategoryRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.SubCategoryRepository
{
    public class SubCategoryCommandRepository : GeneralCommandRepository<SubCategoryModel>, ISubCategoryCommandRepository
    {
        public SubCategoryCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
