using AutoMapper;
using BusinessLogic.UseCase.Crud.Category.Command.AddCategory;
using BusinessLogic.UseCase.Crud.Category.Command.UpdateCategory;
using BusinessLogic.UseCase.Crud.SubCategory.Command.AddSubCategory;
using BusinessLogic.UseCase.Crud.SubCategory.Command.UpdateSubCategory;
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
        }
    }
}
