using DataAccess.EntityModel;
using DataAccess.IRepositories.IGeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories.IDetailStockRepository
{
    public interface IDetailStockQueryRepository : IGeneralQueryRepository<DetailStockModel>
    {
    }
}
