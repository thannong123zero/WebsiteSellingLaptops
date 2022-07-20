using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IGoodsBillRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.GoodsBillRepository
{
    public class GoodsBillCommandRepository : GeneralCommandRepository<GoodsBillModel>, IGoodsBillCommandRepository
    {
        public GoodsBillCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
