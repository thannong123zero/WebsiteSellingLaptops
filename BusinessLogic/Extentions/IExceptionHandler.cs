using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogic.Extentions
{
    public interface IExceptionHandler<in TException, out TOutput> where TException : Exception where TOutput : ProblemDetails
    {
        TOutput Handle(TException exception);
    }
}
