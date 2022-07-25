using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IWithdrawMoneyRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.WithdrawMoneyRepository
{
    public class WithdrawMoneyQueryRepository : GeneralQueryRepository<WithdrawMoneyModel>, IWithdrawMoneyQueryRepository
    {
        public WithdrawMoneyQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}