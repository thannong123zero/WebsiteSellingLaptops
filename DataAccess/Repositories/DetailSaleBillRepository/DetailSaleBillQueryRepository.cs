using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailSaleBillRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailSaleBillRepository
{
    public class DetailSaleBillQueryRepository : GeneralQueryRepository<DetailSaleBillModel>, IDetailSaleBillQueryRepository
    {
        public DetailSaleBillQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
