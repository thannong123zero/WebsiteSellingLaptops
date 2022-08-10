using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.ViewModel;
using MediatR;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Query.GetManufacturing
{
    public class GetManufacturingRequest : IRequest<ManufacturingViewModel>
    {
        public Guid Id { get; set; }
    }
}
