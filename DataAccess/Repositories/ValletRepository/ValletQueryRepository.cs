using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IValletRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ValletRepository
{
    public class ValletQueryRepository : GeneralQueryRepository<ValletModel>, IValletQueryRepository
    {
        public ValletQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
