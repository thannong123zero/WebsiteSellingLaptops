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
    public class PaymentMethodCommandRepository : GeneralCommandRepository<PaymentMethodModel>, IPaymentMethodCommandRepository
    {
        public PaymentMethodCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
