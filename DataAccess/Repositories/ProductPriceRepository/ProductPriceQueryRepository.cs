using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IProductPriceRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ProductPriceRepository
{
    public class ProductPriceQueryRepository : GeneralQueryRepository<ProductPriceModel>, IProductPriceQueryRepository
    {
        public ProductPriceQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
