using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IPaymentMethodRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.PaymentMethodRepository
{
    public class PaymentMethodQueryRepository : GeneralQueryRepository<PaymentMethodModel>, IPaymentMethodQueryRepository
    {
        public PaymentMethodQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
