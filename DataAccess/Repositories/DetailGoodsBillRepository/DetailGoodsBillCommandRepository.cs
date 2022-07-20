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
    public class DetailGoodsBillCommandRepository : GeneralCommandRepository<DetailGoodsBillModel>, IDetailGoodsBillCommandRepository
    {
        public DetailGoodsBillCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
