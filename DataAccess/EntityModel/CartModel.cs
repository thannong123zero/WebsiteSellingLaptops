using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class CartModel : BaseEntityModel
    {
        public Guid CustomerId { get; set; }
        public double TotalMoney { get; set; }
        public CustomerModel Customer { get; set; }
        public ICollection<DetailCartModel>? DetailCarts { get; set; }

    }
}
