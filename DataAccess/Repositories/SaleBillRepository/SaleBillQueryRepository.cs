using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ISaleBillRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.SaleBillRepository
{
    public class SaleBillQueryRepository : GeneralQueryRepository<SaleBillModel>, ISaleBillQueryRepository
    {
        public SaleBillQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
