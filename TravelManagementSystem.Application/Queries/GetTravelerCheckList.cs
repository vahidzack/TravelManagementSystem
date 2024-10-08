﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Application.DTO;
using TravelManagementSystem.Shared.Abstraction.Queries;

namespace TravelManagementSystem.Application.Queries
{
    public class GetTravelerCheckList : IQuery<TravelerCheckListDTO>
    {
        public Guid Id { get; set; }
    }
}
