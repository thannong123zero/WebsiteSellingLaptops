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
    public class ProducerQueryRepository : GeneralQueryRepository<ProducerModel>, IProducerQueryRepository
    {
        public ProducerQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
