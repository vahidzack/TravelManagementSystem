using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Repositories
{
    public interface ITravelerCheckListRepository
    {
        Task<TravelerCheckList> GetAsync(TravelerCheckListId id);
        Task AddAsync(TravelerCheckList travelerCheckList);
        Task UpdateAsync(TravelerCheckList travelerCheckList);
        Task DeleteAsync(TravelerCheckList travelerCheckList);
    }
}
