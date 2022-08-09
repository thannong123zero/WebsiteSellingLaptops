using BusinessLogic.UseCase.Crud.SubCategory.Command.AddSubCategory;
using BusinessLogic.UseCase.Crud.SubCategory.Command.DeleteSubCategory;
using BusinessLogic.UseCase.Crud.SubCategory.Command.RestoreSubCategory;
using BusinessLogic.UseCase.Crud.SubCategory.Command.UpdateSubCategory;
using BusinessLogic.UseCase.Crud.SubCategory.Query.GetSubCategories;
using BusinessLogic.UseCase.Crud.SubCategory.Query.GetSubCategory;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/SubCategories")]
    public class SubCategoryController : BaseApi<SubCategoryController>
    {

        public SubCategoryController(ICommonComponents<SubCategoryController> commonComponents) : base(commonComponents)
        {
        }


        [HttpPost]
        [Route("AddSubCategory")]
        public async Task<IResponse> AddCategory([FromBody] AddSubCategoryRequest addSubCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(addSubCategoryRequest));
        }

        [HttpPut]
        [Route("UpdateSubCategory")]
        public async Task<IResponse> UpdateCategory([FromBody] UpdateSubCategoryRequest updateSubCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(updateSubCategoryRequest));
        }

        [HttpDelete]
        [Route("DeleteSubCategory")]
        public async Task<IResponse> DeleteCategory([FromQuery] DeleteSubCategoryRequest deleteSubCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(deleteSubCategoryRequest));
        }
        [HttpPatch]
        [Route("RestoreSubCategory")]
        public async Task<IResponse> RestoreCategory([FromQuery] RestoreSubCategoryRequest restoreSubCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(restoreSubCategoryRequest));
        }

        [HttpGet]
        [Route("GetSubCategories")]
        public async Task<IResponse> GetCategories([FromQuery] GetSubCategoriesRequest getSubCategoriesRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getSubCategoriesRequest));
        }

        [HttpGet]
        [Route("GetSubCategory")]
        public async Task<IResponse> GetCategory([FromQuery] GetSubCategoryRequest getSubCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getSubCategoryRequest));
        }

    }
}
