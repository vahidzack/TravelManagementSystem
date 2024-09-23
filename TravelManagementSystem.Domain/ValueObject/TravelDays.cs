using TravelManagementSystem.Domain.Exceptions;

namespace TravelManagementSystem.Domain.ValueObject
{
    public record TravelDays
    {
     public ushort Value {  get; }

        public TravelDays(ushort value)
        {
            if (value is 0 or >100)
            {
                throw new InvalidTravelDaysEcxeption(value);
            }
            Value = value;
        }

        public static implicit operator ushort(TravelDays days) => days.Value;
        public static implicit operator TravelDays(ushort days) => new (days);
    }
}
