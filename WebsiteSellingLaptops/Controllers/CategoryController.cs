using BusinessLogic.UseCase.Crud.Category.Command.AddCategory;
using BusinessLogic.UseCase.Crud.Category.Command.DeleteCategory;
using BusinessLogic.UseCase.Crud.Category.Command.RestoreCategory;
using BusinessLogic.UseCase.Crud.Category.Command.UpdateCategory;
using BusinessLogic.UseCase.Crud.Category.Query.GetCategories;
using BusinessLogic.UseCase.Crud.Category.Query.GetCategory;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Categories")]
    public class CategoryController : BaseApi<CategoryController>
    {

        public CategoryController(ICommonComponents<CategoryController> commonComponents) : base(commonComponents){}


        [HttpPost]
        [Route("AddCategory")]
        public async Task<IResponse> AddCategory([FromBody] AddCategoryRequest addCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(addCategoryRequest));
        }

        [HttpPut]
        [Route("UpdateCategory")]
        public async Task<IResponse> UpdateCategory([FromBody] UpdateCategoryRequest updateCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(updateCategoryRequest));
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public async Task<IResponse> DeleteCategory([FromQuery] DeleteCategoryRequest deleteCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(deleteCategoryRequest));
        }
        [HttpPatch]
        [Route("RestoreCategory")]
        public async Task<IResponse> RestoreCategory([FromQuery] RestoreCategoryRequest restoreCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(restoreCategoryRequest));
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<IResponse> GetCategories([FromQuery] GetCategoriesRequest getCategoriesRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getCategoriesRequest));
        }
        [HttpGet]
        [Route("GetCategory")]
        public async Task<IResponse> GetCategory([FromQuery] GetCategoryRequest getCategoryRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getCategoryRequest));
        }

    }
}
