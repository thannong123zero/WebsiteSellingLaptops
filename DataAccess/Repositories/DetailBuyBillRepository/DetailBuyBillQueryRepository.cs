using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailBuyBillRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailBuyBillRepository
{
    public class DetailBuyBillQueryRepository : GeneralQueryRepository<DetailBuyBillModel>, IDetailBuyBillQueryRepository
    {
        public DetailBuyBillQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
