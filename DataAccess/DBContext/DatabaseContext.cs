using DataAccess.EntityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class DatabaseContext :  IdentityDbContext<UserModel,IdentityRole<Guid>,Guid>
    {
        #region DbsetEntity
        
        public DbSet<BuyBillModel> BuyBill { get; set; }
        public DbSet<CartModel> Cart { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<DetailBuyBillModel> DetailBuyBill { get; set; }
        public DbSet<DetailCartModel> DetailCart { get; set; }
        public DbSet<DetailGoodsBillModel> DetailGoodsBill { get; set; }
        public DbSet<DetailSaleBillModel> DetailSaleBill { get; set; }
        public DbSet<DetailStockModel> DetailStock { get; set; }
        public DbSet<BillTypeModel> BillType { get; set; }
        public DbSet<GoodsBillModel> GoodsBill { get; set; }
        public DbSet<ManufactoringModel> Manufactoring { get; set; }
        public DbSet<PaymentMethodModel> PaymentMethod { get; set; }
        public DbSet<WithdrawMoneyModel> PaySip { get; set; }
        public DbSet<ProducerModel> Producer { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<ProductPriceModel> ProductPrice { get; set; }
        public DbSet<ReceiptModel> Receipt { get; set; }
        public DbSet<SaleBillModel> SaleBill { get; set; }
        public DbSet<SubCategoryModel> SubCategory { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<WalletModel> Wallet { get; set; }
        public DbSet<WareHourseModel> WareHourse { get; set; }
        #endregion
        public DatabaseContext() : base() { }
        public DatabaseContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }
    }
}
