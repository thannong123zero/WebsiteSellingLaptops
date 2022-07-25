using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IWithdrawMoneyRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.WithdrawMoneyRepository
{
    public class WithdrawMoneyCommandRepository : GeneralCommandRepository<WithdrawMoneyModel>, IWithdrawMoneyCommandRepository
    {
        public WithdrawMoneyCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
