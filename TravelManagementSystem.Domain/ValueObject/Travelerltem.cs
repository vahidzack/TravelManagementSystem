using TravelManagementSystem.Domain.Exceptions;

namespace TravelManagementSystem.Domain.ValueObject
{
    public record Travelerltem
    {
        public string Name { get; }
        public uint Quantity { get; }

        public bool IsTaken { get; init; }

        public Travelerltem(string name, uint quantity, bool isTaken)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new TravelItemNameException();
            }

            Name = name;
            Quantity = quantity;
            IsTaken = isTaken;
        }

    }


}
