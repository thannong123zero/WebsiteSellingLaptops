using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IGoodsBillRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.GoodsBillRepository
{
    public class GoodsBillQueryRepository : GeneralQueryRepository<GoodsBillModel>, IGoodsBillQueryRepository
    {
        public GoodsBillQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
