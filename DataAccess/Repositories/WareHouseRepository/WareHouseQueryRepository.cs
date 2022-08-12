using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IWareHouseRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.WareHouseRepository
{
    public class WareHouseQueryRepository : GeneralQueryRepository<WareHouseModel>, IWareHouseQueryRepository
    {
        public WareHouseQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
