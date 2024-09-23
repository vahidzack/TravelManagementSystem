using TravelManagementSystem.Domain.Exceptions;

namespace TravelManagementSystem.Domain.ValueObject
{
    public record TravelerItem
    {
        public string Name { get; }
        public uint Quantity { get; }

        public bool IsTaken { get; init; }

        public TravelerItem(string name, uint quantity, bool isTaken = false)
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
