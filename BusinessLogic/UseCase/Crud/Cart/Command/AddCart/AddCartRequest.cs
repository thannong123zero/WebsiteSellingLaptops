using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Command.AddCart
{
    public class AddCartRequest : IRequest<CartViewModel>
    {
        public Guid CustomerId { get; set; }
        public double TotalMoney { get; set; }
    }
}
