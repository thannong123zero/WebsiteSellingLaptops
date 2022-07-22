using DataAccess.IRepositories.IBuyBillRepository;
using DataAccess.Repositories.BuyBillRepository;
using DataAccess.IRepositories.IBillTypeRepository;
using DataAccess.Repositories.BillTypeRepository;
using DataAccess.IRepositories.ICartRepository;
using DataAccess.Repositories.CartRepository;
using DataAccess.IRepositories.ICategoryRepository;
using DataAccess.Repositories.CategoryRepository;
using DataAccess.IRepositories.ICustomerRepository;
using DataAccess.Repositories.CustomerRepository;
using DataAccess.IRepositories.IDetailBuyBillRepository;
using DataAccess.Repositories.DetailBuyBillRepository;
using DataAccess.IRepositories.IDetailCartRepository;
using DataAccess.Repositories.DetailCartRepository;
using DataAccess.IRepositories.IDetailGoodsBillRepository;
using DataAccess.Repositories.DetailGoodsBillRepository;
using DataAccess.IRepositories.IDetailSaleBillRepository;
using DataAccess.Repositories.DetailSaleBillRepository;
using DataAccess.IRepositories.IDetailStockRepository;
using DataAccess.Repositories.DetailStockRepository;
using DataAccess.IRepositories.IGeneralRepository;
using DataAccess.Repositories.GeneralRepository;
using DataAccess.IRepositories.IGoodsBillRepository;
using DataAccess.Repositories.GoodsBillRepository;
using DataAccess.IRepositories.IManufactoringRepository;
using DataAccess.Repositories.ManufactoringRepository;
using DataAccess.IRepositories.IMethodKindRepository;
using DataAccess.Repositories.MethodKindRepository;
using DataAccess.IRepositories.IPaymentMethodRepository;
using DataAccess.Repositories.PaymentMethodRepository;
using DataAccess.IRepositories.IProducerRepository;
using DataAccess.Repositories.ProducerRepository;
using DataAccess.IRepositories.IProductRepository;
using DataAccess.Repositories.ProductRepository;
using DataAccess.IRepositories.IProductPriceRepository;
using DataAccess.Repositories.ProductPriceRepository;
using DataAccess.IRepositories.IReceiptRepository;
using DataAccess.Repositories.ReceiptRepository;
using DataAccess.IRepositories.ISaleBillRepository;
using DataAccess.Repositories.SaleBillRepository;
using DataAccess.IRepositories.ISubCategoryRepository;
using DataAccess.Repositories.SubCategoryRepository;
using DataAccess.IRepositories.IUserRepository;
using DataAccess.Repositories.UserRepository;
using DataAccess.IRepositories.IValletRepository;
using DataAccess.Repositories.ValletRepository;
using DataAccess.IRepositories.IWareHourseRepository;
using DataAccess.Repositories.WareHourseRepository;
using DataAccess.IRepositories.IWithdrawMoneyRepository;
using DataAccess.Repositories.WithdrawMoneyRepository;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using System.Reflection;
using MediatR;
using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DataAccess.EntityModel;
using Microsoft.AspNetCore.Identity;
using BusinessLogic.UseCase.Crud.Category.Command.AddCategory;
using ZWA.Infrastructure.Core;

namespace WebsiteSellingLaptops
{
    public static class SignUpService 
    {
        public static IServiceCollection SignUpSerVice(this IServiceCollection services)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json")
            .Build();

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(
                    configuration["ConnectionStrings:LinkSQL"],
                    b => b.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName)));

            services.AddIdentity<UserModel, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<DatabaseContext>()
                .AddDefaultTokenProviders();
            //"AllowedAssemblyPattern": "BusinessLogic" add into appsetting.js I don't why
            var assemblies = configuration.LoadApplicationAssemblies();

            services.AddMediatR(assemblies.ToArray());

            services.AddCommandRepository();
            services.AddQueyRepository();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
           
            return services;
        }
        public static IServiceCollection AddCommandRepository(this IServiceCollection services)
        {
            services.AddScoped<IBillTypeCommandRepository, BillTypeCommandRepository>();
            services.AddScoped<IBuyBillCommandRepository, BuyBillCommandRepository>();
            services.AddScoped<ICartCommandRepository, CartCommandRepository>();
            services.AddScoped<ICategoryCommandRepository, CategoryCommandRepository>();
            services.AddScoped<ICustomerCommandRepository, CustomerCommandRepository>();
            services.AddScoped<IDetailBuyBillCommandRepository, DetailBuyBillCommandRepository>();
            services.AddScoped<IDetailCartCommandRepository, DetailCartCommandRepository>();        
            services.AddScoped<IDetailGoodsBillCommandRepository, DetailGoodsBillCommandRepository>();
            services.AddScoped<IDetailSaleBillCommandRepository, DetailSaleBillCommandRepository>();
            services.AddScoped<IDetailStockCommandRepository, DetailStockCommandRepository>();
            //services.AddScoped<IGeneralCommandRepository,GeneralCommandRepository<Entity>();
            services.AddScoped<IGoodsBillCommandRepository, GoodsBillCommandRepository>();
            services.AddScoped<IManufactoringCommandRepository, ManufactoringCommandRepository>();
            services.AddScoped<IMethodKindCommandRepository, MethodKindCommandRepository>();
            services.AddScoped<IPaymentMethodCommandRepository, PaymentMethodCommandRepository>();
            services.AddScoped<IProducerCommandRepository, ProducerCommandRepository>();
            services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            services.AddScoped<IProductPriceCommandRepository, ProductPriceCommandRepository>();
            services.AddScoped<IReceiptCommandRepository, ReceiptCommandRepository>();
            services.AddScoped<ISaleBillCommandRepository, SaleBillCommandRepository>();
            services.AddScoped<ISubCategoryCommandRepository, SubCategoryCommandRepository>();
            services.AddScoped<IUserCommandRepository, UserCommandRepository>();
            services.AddScoped<IValletCommandRepository, ValletCommandRepository>();
            services.AddScoped<IWareHourseCommandRepository, WareHourseCommandRepository>();
            services.AddScoped<IWithdrawMoneyCommandRepository, WithdrawMoneyCommandRepository>();

            return services;
        }
        public static IServiceCollection AddQueyRepository(this IServiceCollection services)
        {
            services.AddScoped<IBillTypeQueryRepository,BillTypeQueryRepository>();
            services.AddScoped<IBuyBillQueryRepository,BuyBillQueryRepository>();
            services.AddScoped<ICartQueryRepository,CartQueryRepository>();
            services.AddScoped<ICategoryQueryRepository, CategoryQueryRepository>();
            services.AddScoped<ICustomerQueryRepository, CustomerQueryRepository>();
            services.AddScoped<IDetailBuyBillQueryRepository, DetailBuyBillQueryRepository>();
            services.AddScoped<IDetailCartQueryRepository, DetailCartQueryRepository>();
            services.AddScoped<IDetailGoodsBillQueryRepository, DetailGoodsBillQueryRepository>();
            services.AddScoped<IDetailSaleBillQueryRepository, DetailSaleBillQueryRepository>();
            services.AddScoped<IDetailStockQueryRepository, DetailStockQueryRepository>();
            //services.AddScoped<IGeneralQueryRepository,GeneralQueryRepository<Entity>();
            services.AddScoped<IGoodsBillQueryRepository, GoodsBillQueryRepository>();
            services.AddScoped<IManufactoringQueryRepository, ManufactoringQueryRepository>();
            services.AddScoped<IMethodKindQueryRepository, MethodKindQueryRepository>();
            services.AddScoped<IPaymentMethodQueryRepository, PaymentMethodQueryRepository>();
            services.AddScoped<IProducerQueryRepository, ProducerQueryRepository>();
            services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
            services.AddScoped<IProductPriceQueryRepository, ProductPriceQueryRepository>();
            services.AddScoped<IReceiptQueryRepository, ReceiptQueryRepository>();
            services.AddScoped<ISaleBillQueryRepository, SaleBillQueryRepository>();
            services.AddScoped<ISubCategoryQueryRepository, SubCategoryQueryRepository>();
            services.AddScoped<IUserQueryRepository, UserQueryRepository>();
            services.AddScoped<IValletQueryRepository, ValletQueryRepository>();
            services.AddScoped<IWareHourseQueryRepository, WareHourseQueryRepository>();
            services.AddScoped<IWithdrawMoneyQueryRepository, WithdrawMoneyQueryRepository>();
            return services;
        }
    }
}
