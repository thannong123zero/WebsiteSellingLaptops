using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IProductRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ProductRepository
{
    public class ProductCommandRepository : GeneralCommandRepository<ProductModel>, IProductCommandRepository
    {
        public ProductCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
