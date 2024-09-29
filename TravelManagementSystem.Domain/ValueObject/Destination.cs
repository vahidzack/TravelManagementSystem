
namespace TravelManagementSystem.Domain.ValueObject
{
    public record Destination(string City,string Country)
    {
        public static Destination Create(string value)
        {   
            var splitDestination = value.Split(',');
            return new Destination(splitDestination.First(), splitDestination.Last());
        }
        public override string ToString()=>
            $"{City}:{Country}";

        public static implicit operator Destination?(TravelManagementSystem.Application.DTO.DestinationDTO? v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Destination(TravelManagementSystem.Application.DTO.DestinationDTO v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Destination(TravelManagementSystem.Application.DTO.DestinationDTO v)
        {
            throw new NotImplementedException();
        }
    }
}
