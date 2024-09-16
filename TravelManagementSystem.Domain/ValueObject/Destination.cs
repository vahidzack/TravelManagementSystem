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
    }
}
