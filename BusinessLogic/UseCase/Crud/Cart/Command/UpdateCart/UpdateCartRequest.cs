using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Command.UpdateCart
{
    public class UpdateCartRequest : IRequest<CartViewModel>
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public double TotalMoney { get; set; }
    }
}
