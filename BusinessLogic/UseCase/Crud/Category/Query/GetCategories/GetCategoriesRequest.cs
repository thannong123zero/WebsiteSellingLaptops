using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Query.GetCategories
{
    public class GetCategoriesRequest : IRequest<List<CategoryViewModel>>
    {

    }
}
