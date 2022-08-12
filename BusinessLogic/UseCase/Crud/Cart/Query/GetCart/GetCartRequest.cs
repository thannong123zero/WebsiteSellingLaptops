using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Query.GetCart
{
    public class GetCartRequest : IRequest<CartViewModel>
    {
        public Guid Id { get; set; }
    }
}
