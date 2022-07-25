using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailGoodsBillRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailGoodsBillRepository
{
    public class DetailGoodsBillQueryRepository : GeneralQueryRepository<DetailGoodsBillModel>, IDetailGoodsBillQueryRepository
    {
        public DetailGoodsBillQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
