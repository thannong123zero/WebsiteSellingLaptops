using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.WareHouse.Query.GetWareHouse
{
    public class GetWareHouseRequest : IRequest<WareHouseViewModel>
    {
        public Guid Id { get; set; }
    }
}
