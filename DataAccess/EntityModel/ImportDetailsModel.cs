using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ImportDetailsModel
    {
        public Guid Id { get; set; }
        public Guid WareHourseId { get; set; }
        public Guid ProductId { get; set; }
        public int  Quantity { get; set; }
    }
}
