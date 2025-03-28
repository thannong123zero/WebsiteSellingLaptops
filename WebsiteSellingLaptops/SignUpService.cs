﻿#region namespace
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
using FluentValidation.AspNetCore;
using FluentValidation;
using AutoMapper;
using BusinessLogic.Extentions.BaseRequestValidators;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Formatters;
using DataAccess.Repositories.WalletRepository;
using DataAccess.IRepositories.IWalletRepository;
using WebsiteSellingLaptops.CustomController;
using BusinessLogic.Extentions;
using Microsoft.AspNetCore.Mvc;
using ZWA.Core.Domain.Exceptions;
using DataAccess.IRepositories.IManufacturingRepository;
using DataAccess.Repositories.ManufacturingRepository;
using DataAccess.Repositories.WareHouseRepository;
using DataAccess.IRepositories.IWareHouseRepository;
using DataAccess.IRepositories.IRoleRepository;
using DataAccess.Repositories.RoleRepository;

#endregion
namespace WebsiteSellingLaptops
{
    public static class SignUpService 
    {
        public static IServiceCollection SignUpSerVice(this IServiceCollection services)
        {
            
            #region sign up database context
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json")
            .Build();
            //"AllowedAssemblyPattern": "BusinessLogic" add into appsetting.js I don't why
            var assemblies = configuration.LoadApplicationAssemblies();

            // sign up database context
            services.AddDbContext<DbContext,DatabaseContext>(options =>
                options.UseSqlServer(
                    configuration["ConnectionStrings:LinkSQL"],
                    b => b.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName)));

            // sign up identity 
            //services.AddIdentity<UserModel, RoleModel>()
            //    .AddEntityFrameworkStores<DatabaseContext>()
            //    .AddDefaultTokenProviders();

            services.AddIdentityCore<UserModel>()
                .AddRoles<RoleModel>()
            .AddTokenProvider<DataProtectorTokenProvider<UserModel>>("MyShop")
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();

            #endregion
            #region Add middle ware manager fluent validation
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestValidationHandler<,>));
            var mvcBuilder = services.AddRouting(ex => ex.LowercaseUrls = true)
                                    .AddControllers(ex =>
                                    {
                                        var notJsonOutputFormatters = ex.OutputFormatters.Where(formatter => !(formatter is SystemTextJsonOutputFormatter)).ToArray();
                                        foreach (var formatter in notJsonOutputFormatters)
                                        {
                                            ex.OutputFormatters.Remove(formatter);
                                        }
                                    }).AddJsonOptions(ex =>
                                    {
                                        ex.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                                        ex.JsonSerializerOptions.AllowTrailingCommas = false;
                                        ex.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Disallow;
                                    });


            services.AddResponseCaching()
                    .AddHttpContextAccessor()
                    .AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            mvcBuilder.AddFluentValidation(fv =>
            {
                fv.ImplicitlyValidateChildProperties = false;
                //fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                fv.RegisterValidatorsFromAssemblies(assemblies);
            });

            mvcBuilder.ConfigureApiBehaviorOptions(opts =>
            {
                opts.SuppressModelStateInvalidFilter = true;
            });
            // sign up this code to handler erro Global
            services.AddScoped(typeof(IExceptionHandler<FluentValidation.ValidationException, ProblemDetails>), typeof(ValidationExceptionHandler));
            #endregion
            #region sign up service
            services.AddMediatR(assemblies.ToArray());

            services.AddControllers().AddFluentValidation();
            services.AddCommandRepository();
            services.AddQueyRepository();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(ICommonComponents<>), typeof(CommonComponents<>));

            services.AddControllersWithViews().AddNewtonsoftJson(options =>
             options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            #endregion
            #region Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SignUpAutoMapper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion
            
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
            services.AddScoped<IManufacturingCommandRepository, ManufacturingCommandRepository>();
            services.AddScoped<IPaymentMethodCommandRepository, PaymentMethodCommandRepository>();
            services.AddScoped<IProducerCommandRepository, ProducerCommandRepository>();
            services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            services.AddScoped<IProductPriceCommandRepository, ProductPriceCommandRepository>();
            services.AddScoped<IReceiptCommandRepository, ReceiptCommandRepository>();
            services.AddScoped<ISaleBillCommandRepository, SaleBillCommandRepository>();
            services.AddScoped<ISubCategoryCommandRepository, SubCategoryCommandRepository>();
            services.AddScoped<IUserCommandRepository, UserCommandRepository>();
            services.AddScoped<IWalletCommandRepository, WalletCommandRepository>();
            services.AddScoped<IWareHouseCommandRepository, WareHouseCommandRepository>();
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
            //services.AddScoped<IGeneralQueryRepository,GeneralQueryRepository<Entity>()
            services.AddScoped<IRoleQueryRepository,RoleQueryRepository>();
            services.AddScoped<IGoodsBillQueryRepository, GoodsBillQueryRepository>();
            services.AddScoped<IManufacturingQueryRepository, ManufacturingQueryRepository>();
            services.AddScoped<IPaymentMethodQueryRepository, PaymentMethodQueryRepository>();
            services.AddScoped<IProducerQueryRepository, ProducerQueryRepository>();
            services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
            services.AddScoped<IProductPriceQueryRepository, ProductPriceQueryRepository>();
            services.AddScoped<IReceiptQueryRepository, ReceiptQueryRepository>();
            services.AddScoped<ISaleBillQueryRepository, SaleBillQueryRepository>();
            services.AddScoped<ISubCategoryQueryRepository, SubCategoryQueryRepository>();
            services.AddScoped<IUserQueryRepository, UserQueryRepository>();
            services.AddScoped<IWalletQueryRepository, WalletQueryRepository>();
            services.AddScoped<IWareHouseQueryRepository, WareHouseQueryRepository>();
            services.AddScoped<IWithdrawMoneyQueryRepository, WithdrawMoneyQueryRepository>();
            return services;
        }
    }
}
