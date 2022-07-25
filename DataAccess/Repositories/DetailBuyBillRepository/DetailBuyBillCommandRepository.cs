using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailBuyBillRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailBuyBillRepository
{
    public class DetailBuyBillCommandRepository : GeneralCommandRepository<DetailBuyBillModel>, IDetailBuyBillCommandRepository
    {
        public DetailBuyBillCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
