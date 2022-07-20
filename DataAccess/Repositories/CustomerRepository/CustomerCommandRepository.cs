using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ICustomerRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.CustomerRepository
{
    public class CustomerCommandRepository : GeneralCommandRepository<CustomerModel>, ICustomerCommandRepository
    {
        public CustomerCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
