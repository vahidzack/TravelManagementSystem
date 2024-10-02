namespace TravelManagementSystem.Application.DTO
{
    public class TravelerCheckListDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DestinationDTO Destination { get; set; }
        public IEnumerable<TravelerItemDTO> Items { get; set; }
    }
}
