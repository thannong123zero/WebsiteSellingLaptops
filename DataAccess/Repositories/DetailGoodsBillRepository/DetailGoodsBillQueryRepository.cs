using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailGoodsBillRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailGoodsBillRepository
{
    public class DetailGoodsBillQueryRepository : GeneralQueryRepository<DetailGoodsBillModel>, IDetailGoodsBillQueryRepository
    {
        public DetailGoodsBillQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
