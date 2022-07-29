using BusinessLogic.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.AddCategory
{
    public class AddCategoryRequest : IRequest<CategoryViewModel>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
