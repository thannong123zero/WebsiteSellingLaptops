using DataAccess.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class DatabaseContext : DbContext
    {
        #region Dbset
        public DbSet<AdminModel> Admins { get; set; }
        public DbSet<BillModel> Bills { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ImportDetailsModel> ImportDetails { get; set; }
        public DbSet<InvoiceDetailsModel> InvoiceDetails { get; set; }
        public DbSet<KindOfBillModel> KindOfBills { get; set; }
        public DbSet<ProductInRepositoryModel> ProductInRepositories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ProductOfPriceModel> ProductOfPrices { get; set; }
        public DbSet<SubCategoryModel> SubCategorise { get; set; }
        public DbSet<WareHourseModel> WareHourses { get; set; }
        #endregion
        public DatabaseContext() : base() { }
        public DatabaseContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
