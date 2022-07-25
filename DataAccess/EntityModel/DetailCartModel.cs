using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class DetailCartModel : BaseEntityModel
    {        
        public Guid ProductId { get; set; }
        public Guid CartId { get; set; }
        public int Quantity { get; set; }
        public CartModel Cart { get; set; }
        public ProductModel Product { get; set; }
    }
}
