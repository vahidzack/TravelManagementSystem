using Microsoft.EntityFrameworkCore;
using TravelManagementSystem.Application.Services;
using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Infrastructure.EF.Models;

namespace TravelManagementSystem.Infrastructure.EF.Services
{
    internal sealed class TravelerCheckReadService : ITravelerCheckReadService
    {
        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;

        public TravelerCheckReadService(DbSet<TravelerCheckListReadModel> travelerCheckList) => _travelerCheckList = travelerCheckList;

        public Task<bool> ExistByName(string name) => _travelerCheckList.AnyAsync(x => x.Name == name);
    }
}
