using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class WareHourseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<GoodsBillModel> GoodsBills { get; set; }
        public ICollection<DetailStockModel> DetailStocks { get; set; }

    }
}
