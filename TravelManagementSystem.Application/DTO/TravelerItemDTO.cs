using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagementSystem.Application.DTO
{
    public class TravelerItemDTO
    {
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public bool IsTaken { get; set; }
    }
}
