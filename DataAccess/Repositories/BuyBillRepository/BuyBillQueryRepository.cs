using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IBuyBillRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.BuyBillRepository
{
    public class BuyBillQueryRepository : GeneralQueryRepository<BuyBillModel>, IBuyBillQueryRepository
    {
        public BuyBillQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
