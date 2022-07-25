using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IWareHourseRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.WareHourseRepository
{
    public class WareHourseCommandRepository : GeneralCommandRepository<WareHourseModel>, IWareHourseCommandRepository
    {
        public WareHourseCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
