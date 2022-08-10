using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.UpdateManufacturing
{
    public class UpdateManufacturingRequest : IRequest<ManufacturingViewModel>
    {
        public Guid Id { get; set; }
        public string MadeIn { get; set; }
        public string? Description { get; set; }
    }
}
