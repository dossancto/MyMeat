using FluentValidation;
using MyMeat.Application.Exceptions;

namespace MyMeat.Application.Utils.Validation;

public static class Validator
{
    public static void Validate<T>(IValidator<T> validator, T value, string message)
    {
        var result = validator.Validate(value);

        if (!result.IsValid)
        {
            var errors = result
              .Errors
              .Select(e => new ValidationFailException.ValidationError(e.ErrorMessage, e.PropertyName))
              .ToList();

            throw new ValidationFailException(message, errors);
        }
    }
}
