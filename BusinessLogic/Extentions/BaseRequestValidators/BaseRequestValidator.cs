using BusinessLogic.Extentions;
using FluentValidation;
using FluentValidation.Results;


namespace BusinessLogic.Extentions.BaseRequestValidators
{
    public class BaseRequestValidator<Request> : AbstractValidator<Request>
    {
        protected override bool PreValidate(ValidationContext<Request> context, ValidationResult result)
        {
            bool isContinueTheValidation = true;

            if (context.InstanceToValidate == null)
            {
                result.Errors.Add(new ValidationFailure(string.Empty, Constants.RequestHandling.Messages.InvalidRequest));
                isContinueTheValidation = false;
            }

            return isContinueTheValidation;
        }
    }
}
