using MyMeat.Application.App.Meats.Entities;

namespace MyMeat.Infra.App.Meats.Entities;

public class DynamoMeat : Meat
{
    public DynamoMeat(Meat meat)
    {
        Id = Guid.NewGuid();
        Name = meat.Name;
        Description = meat.Description;
        Price = meat.Price;
        Validade = meat.Validade;
    }

    public string PK => Id.ToString();
    public string SK => PK;
}
