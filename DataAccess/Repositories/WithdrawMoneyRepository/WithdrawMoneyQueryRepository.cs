using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IWithdrawMoneyRepository;
using DataAccess.Repositories.GeneralRepository;
namespace DataAccess.Repositories.WithdrawMoneyRepository
{
    public class WithdrawMoneyQueryRepository : GeneralQueryRepository<WithdrawMoneyModel>, IWithdrawMoneyQueryRepository
    {
        public WithdrawMoneyQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}