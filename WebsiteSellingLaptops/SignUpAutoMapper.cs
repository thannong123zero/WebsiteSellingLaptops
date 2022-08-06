using AutoMapper;
using BusinessLogic.UseCase.Crud.Category.Command.AddCategory;
using BusinessLogic.UseCase.Crud.Category.Command.UpdateCategory;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;

namespace WebsiteSellingLaptops
{
    public class SignUpAutoMapper : Profile
    {
        public SignUpAutoMapper()
        {
            CreateMap<CategoryModel, CategoryViewModel>();
            CreateMap<AddCategoryRequest, CategoryModel>();
            CreateMap<UpdateCategoryRequest, CategoryModel>();
        }
    }
}
