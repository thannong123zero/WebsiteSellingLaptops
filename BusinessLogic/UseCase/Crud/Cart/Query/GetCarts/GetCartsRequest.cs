using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Query.GetCarts
{
    public class GetCartsRequest : IRequest<List<CartViewModel>>
    {
    }
}
