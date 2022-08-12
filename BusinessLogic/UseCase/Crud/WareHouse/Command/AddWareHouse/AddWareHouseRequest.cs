using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.WareHouse.Command.AddWareHouse
{
    public class AddWareHouseRequest : IRequest<WareHouseViewModel>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
