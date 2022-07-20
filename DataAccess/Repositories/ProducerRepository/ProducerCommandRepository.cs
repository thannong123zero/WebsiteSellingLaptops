using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IProducerRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ProducerRepository
{
    public class ProducerCommandRepository : GeneralCommandRepository<ProducerModel>, IProducerCommandRepository
    {
        public ProducerCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
