using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMeat.Application.App.Meats.Entities;

namespace MyMeat.Infra.Data.Configurations.Meats;

public class MeatConfiguration : IEntityTypeConfiguration<Meat>
{
    public void Configure(EntityTypeBuilder<Meat> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(64);

        builder.Property(x => x.Description).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Price).IsRequired().HasPrecision(5, 2);

        builder.Property(x => x.Validade).IsRequired();

        builder.Property(x => x.CreatedAt).ValueGeneratedOnAdd();
        builder.Property(x => x.UpdatedAt).ValueGeneratedOnAddOrUpdate();
    }
}
