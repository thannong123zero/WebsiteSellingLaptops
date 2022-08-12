using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class GoodsBillModel : BaseEntityModel
    {
        public Guid EmployeeId { get; set; }
        public Guid WareHourseId { get; set; }
        public Guid BillTypeId { get; set; }
        public double Money { get; set; }
        public DateTime CreateAt { get; set; }
        public UserModel User { get; set; }
        public BillTypeModel BillType { get; set; }
        public WareHouseModel WareHourse { get; set; }
        public ICollection<DetailGoodsBillModel>? DetailGoodsBills { get; set; }
    }
}
