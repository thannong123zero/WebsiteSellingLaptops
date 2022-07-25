using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailSaleBillRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailSaleBillRepository
{
    public class DetailSaleBillCommandRepository : GeneralCommandRepository<DetailSaleBillModel>, IDetailSaleBillCommandRepository
    {
        public DetailSaleBillCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
