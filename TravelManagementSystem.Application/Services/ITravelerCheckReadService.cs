using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagementSystem.Application.Services
{
    public interface ITravelerCheckReadService
    {
        Task<bool> ExistByName(string name);
    }
}
