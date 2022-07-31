using BusinessLogic.UseCase.Crud.Category.Command.AddCategory;
using BusinessLogic.UseCase.Crud.Category.Query.GetCategories;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Categories")]
    public class CategoryController : Controller
    {
        private readonly ICategoryCommandRepository _categoryCommandRepository;
        private readonly ICategoryQueryRepository _categoryQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator,
            ICategoryCommandRepository categoryCommandRepository,
            ICategoryQueryRepository categoryQueryRepository,
            IUnitOfWork unitOfWork)
        {
            _categoryCommandRepository = categoryCommandRepository;
            _categoryQueryRepository = categoryQueryRepository;
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }


        [HttpPost]
        [Route("AddCategory")]
        public async Task<IActionResult> AddCategory([FromBody] AddCategoryRequest addCategoryRequest)
        {

           // var result = _categoryQueryRepository.GetAll();

            var result = await _mediator.Send(addCategoryRequest);


            return  StatusCode(200,result);
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<IActionResult> GetCategories([FromQuery] GetCategoriesRequest getCategoriesRequest)
        {
            var result = await _mediator.Send(getCategoriesRequest);
            return StatusCode(200, result);
        }
    }
}
