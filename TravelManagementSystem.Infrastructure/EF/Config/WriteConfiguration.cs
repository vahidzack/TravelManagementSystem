using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Infrastructure.EF.Config
{
    internal sealed class WriteConfiguration : IEntityTypeConfiguration<TravelerCheckList>, IEntityTypeConfiguration<TravelerItem>
    {
        public void Configure(EntityTypeBuilder<TravelerCheckList> builder)
        {
            builder.HasKey(pl => pl.Id);
            var destiationConverter = new ValueConverter<Destination, string>(l => l.ToString(),
                l => Destination.Create(l));

            var packingListNameConvertor = new ValueConverter<TravelerCheckListName, string>(pln => pln.ToString(),
                pln => new TravelerCheckListName(pln));

            builder
            .Property(pl => pl.Id)
            .HasConversion(id => id.Value, id => new TravelerCheckListId(id));

            builder
                .Property(typeof(Destination), "_destination")
                .HasConversion(destiationConverter)
                .HasColumnName("Destination");

            builder
                .Property(typeof(TravelerCheckListName), "_name")
                .HasConversion(packingListNameConvertor)
                .HasColumnName("Name");

            builder.HasMany(typeof(TravelerItem), "_item");
            builder.ToTable("TravelerCheckList");

        }

        public void Configure(EntityTypeBuilder<TravelerItem> builder)
        {
            builder.Property<Guid>("Id");
            builder.Property(pi => pi.Name);
            builder.Property(pi => pi.Quantity);
            builder.Property(pi => pi.IsTaken);
            builder.ToTable("TravelerItems");
        }
    }
}
