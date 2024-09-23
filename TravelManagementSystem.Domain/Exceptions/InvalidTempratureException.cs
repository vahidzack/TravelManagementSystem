namespace TravelManagementSystem.Domain.Exceptions
{
    public class InvalidTemperatureException : Exception
    {
        public double Value { get; set; }

        public InvalidTemperatureException(double value) : base($"Value {value} is invalid Temperature" )=> Value = value;
        
    }
}
