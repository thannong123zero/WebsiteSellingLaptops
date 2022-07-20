using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IWareHourseRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.WareHourseRepository
{
    public class WareHourseQueryRepository : GeneralQueryRepository<WareHourseModel>, IWareHourseQueryRepository
    {
        public WareHourseQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
