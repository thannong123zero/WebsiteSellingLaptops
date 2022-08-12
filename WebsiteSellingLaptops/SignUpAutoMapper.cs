using AutoMapper;
using BusinessLogic.UseCase.Crud.Category.Command.AddCategory;
using BusinessLogic.UseCase.Crud.Category.Command.UpdateCategory;
using BusinessLogic.UseCase.Crud.Manufacturing.Command.AddManufacturing;
using BusinessLogic.UseCase.Crud.Manufacturing.Command.UpdateManufacturing;
using BusinessLogic.UseCase.Crud.Producer.Command.AddProducer;
using BusinessLogic.UseCase.Crud.Producer.Command.UpdateProducer;
using BusinessLogic.UseCase.Crud.SubCategory.Command.AddSubCategory;
using BusinessLogic.UseCase.Crud.SubCategory.Command.UpdateSubCategory;
using BusinessLogic.UseCase.Crud.User.Command.AddUser;
using BusinessLogic.UseCase.Crud.User.Command.UpdateUser;
using BusinessLogic.UseCase.Crud.Wallet.Command.AddWallet;
using BusinessLogic.UseCase.Crud.Wallet.Command.UpdateWallet;
using BusinessLogic.UseCase.Crud.WareHouse.Command.AddWareHouse;
using BusinessLogic.UseCase.Crud.WareHouse.Command.UpdateWareHouse;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;

namespace WebsiteSellingLaptops
{
    public class SignUpAutoMapper : Profile
    {
        public SignUpAutoMapper()
        {
            //category
            CreateMap<CategoryModel, CategoryViewModel>();
            CreateMap<AddCategoryRequest, CategoryModel>();
            CreateMap<UpdateCategoryRequest, CategoryModel>();

            //subcategory
            CreateMap<SubCategoryModel, SubCategoryViewModel>();
            CreateMap<AddSubCategoryRequest, SubCategoryModel>();
            CreateMap<UpdateSubCategoryRequest, SubCategoryModel>();

            //user
            CreateMap<UserModel, UserViewModel>();
            CreateMap<AddUserRequest, UserModel>();
            CreateMap<UpdateUserRequest, UserModel>();

            //producer
            CreateMap<ProducerModel, ProducerViewModel>();
            CreateMap<AddProducerRequest, ProducerModel>();
            CreateMap<UpdateProducerRequest, ProducerModel>();

            //manufacturing
            CreateMap<ManufacturingModel, ManufacturingViewModel>();
            CreateMap<AddManufacturingRequest, ManufacturingModel>();
            CreateMap<UpdateManufacturingRequest, ManufacturingModel>();

            //Wallet
            CreateMap<WalletModel, WalletViewModel>();
            CreateMap<AddWalletRequest, WalletModel>();
            CreateMap<UpdateWalletRequest, WalletModel>();

            //ware house
            CreateMap<WareHouseModel, WareHouseViewModel>();
            CreateMap<AddWareHouseRequest, WareHouseModel>();
            CreateMap<UpdateWareHouseRequest, WareHouseModel>();
        }
    }
}
