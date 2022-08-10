using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IManufacturingRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ManufacturingRepository
{
    public class ManufacturingQueryRepository : GeneralQueryRepository<ManufacturingModel>, IManufacturingQueryRepository
    {
        public ManufacturingQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
