using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailStockRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailStockRepository
{
    public class DetailStockQueryRepository : GeneralQueryRepository<DetailStockModel>, IDetailStockQueryRepository
    {
        public DetailStockQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
