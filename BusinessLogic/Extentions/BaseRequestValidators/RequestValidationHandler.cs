﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using FluentValidation;

using MediatR;

namespace BusinessLogic.Extentions.BaseRequestValidators
{
    public class RequestValidationHandler<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public RequestValidationHandler(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var context = new ValidationContext<TRequest>(request);

            var failures = _validators.Select(v => v.Validate(context))
                                      .SelectMany(result => result.Errors)
                                      .Where(f => f != null)
                                      .ToList();

            if (failures.Count > 0)
            {
                throw new ValidationException(failures);
            }

            return await next.Invoke().ConfigureAwait(false);
        }
    }
}
