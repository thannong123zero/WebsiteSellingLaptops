using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;

namespace WebsiteSellingLaptops
{
    public class SignUpAutoMapper : Profile
    {
        public SignUpAutoMapper()
        {
            CreateMap<CategoryViewModel, CategoryModel>();
            CreateMap<CategoryModel, CategoryViewModel>();
        }
    }
}
