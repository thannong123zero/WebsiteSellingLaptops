﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.DeleteManufacturing
{
    public class DeleteManufacturingRequest : IRequest<IActionResult>
    {
        public Guid Id { get; set; }
    }
}
