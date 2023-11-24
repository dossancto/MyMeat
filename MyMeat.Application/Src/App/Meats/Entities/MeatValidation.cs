using FluentValidation;

namespace MyMeat.Application.App.Meats.Entities;

public class MeatValidation : AbstractValidator<Meat>
{
    public MeatValidation()
    {
        RuleFor(x => x.Name).MaximumLength(64);
        RuleFor(x => x.Description).Length(5, 256);
        RuleFor(x => x.Price).GreaterThan(5);
        RuleFor(x => x.Validade).GreaterThan(DateTime.Now.AddMonths(1)).WithMessage("A validade mínima é de 1 Mẽs.");
    }
}

