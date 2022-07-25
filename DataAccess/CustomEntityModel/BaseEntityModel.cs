using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain;
using ZWA.Core.Utils.Helpers;

namespace DataAccess.CustomEntityModel
{
    public class BaseEntityModel : BaseEntity
    {
        protected BaseEntityModel() : base(IdHelper.GenerateId())
        {
            CreateAt = DateTime.Now;
            IsDelete = false;
        }

        protected BaseEntityModel(Guid id) : base(id)
        {
            CreateAt = DateTime.Now;
            IsDelete = false;
        }
        public bool IsDelete { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
