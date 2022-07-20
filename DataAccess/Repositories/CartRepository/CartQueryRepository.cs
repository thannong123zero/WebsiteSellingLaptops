using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ICartRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.CartRepository
{
    public class CartQueryRepository : GeneralQueryRepository<CartModel>, ICartQueryRepository
    {
        public CartQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
