namespace TravelManagementSystem.Infrastructure.EF.Models
{
    internal class TravelerCheckListReadModel
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public DestinationReadModel Destination { get; set; }
        public ICollection<TravelerItemReadModel> Items { get; set; }
    }
}
