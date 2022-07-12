using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class DetailGoodsReceiptNoteModel
    {
        public Guid Id { get; set; }
        public Guid GoodsReceiptNodeId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
