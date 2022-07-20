using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IBuyBillRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.BuyBillRepository
{
    public class BuyBillCommandRepository : GeneralCommandRepository<BuyBillModel>, IBuyBillCommandRepository
    {
        public BuyBillCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
