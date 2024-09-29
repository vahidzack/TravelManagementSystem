using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.ValueObject;

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
