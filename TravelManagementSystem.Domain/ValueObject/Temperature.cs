using TravelManagementSystem.Domain.Exceptions;

namespace TravelManagementSystem.Domain.ValueObject
{
    public record Temperature
    {
        public double Value { get; }

        public Temperature(double value)
        {
            if (value is < -100 or > 100)
            {
                throw new InvalidTemperatureException(value);
            }
            Value = value;

        }
        public static implicit operator double(Temperature temprature) => temprature.Value;
        public static implicit operator Temperature(double temprature) => new(temprature);
    }
}
