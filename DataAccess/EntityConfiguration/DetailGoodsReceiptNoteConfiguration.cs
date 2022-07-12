using DataAccess.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration
{
    public class DetailGoodsReceiptNoteConfiguration : IEntityTypeConfiguration<DetailGoodReceiptNoteModel>
    {
        public void Configure(EntityTypeBuilder<DetailGoodReceiptNoteModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
