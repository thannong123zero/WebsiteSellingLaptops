using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IMethodKindRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.MethodKindRepository
{
    public class MethodKindCommandRepository : GeneralCommandRepository<MethodKindModel>, IMethodKindCommandRepository
    {
        public MethodKindCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
