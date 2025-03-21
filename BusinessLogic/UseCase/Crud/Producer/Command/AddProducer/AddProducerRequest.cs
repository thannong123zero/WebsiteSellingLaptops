﻿using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Producer.Command.AddProducer
{
    public class AddProducerRequest : IRequest<ProducerViewModel>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
    }
}
