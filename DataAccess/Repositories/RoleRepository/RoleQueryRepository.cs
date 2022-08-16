using DataAccess.EntityModel;
using DataAccess.IRepositories.IRoleRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.RoleRepository
{
    public class RoleQueryRepository : GeneralQueryRepository<RoleModel>, IRoleQueryRepository
    {
        public RoleQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
