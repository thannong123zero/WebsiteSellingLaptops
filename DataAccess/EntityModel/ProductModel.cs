using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public Guid SubCategoryId { get; set; }
        public Guid ManufactorId { get; set; } 
        public string ProductName { get; set; }
        public string Descrition { get; set; }
        public string? Img { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? WarrantyPeriod { get; set; }
        public ManufactoringModel Manufactoring { get; set; }
        public SubCategoryModel SubCategory { get; set; }
        public ICollection<DetailCartModel> DetailCarts { get; set; }
        public ICollection<DetailStockModel> DetailStocks { get; set; }
        public ICollection<DetailBuyBillModel> DetailBuyBills { get; set; }
        public ICollection<DetailGoodsBillModel> DetailGoodsBills { get; set; }
        public ICollection<DetailSaleBillModel> DetailSaleBills { get; set; }
        public ICollection<ProductPriceModel> ProductPrices { get; set; }
    }
}
