using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Domain.Repositories;
using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Infrastructure.EF.Contexts;

namespace TravelManagementSystem.Infrastructure.EF.Repositories
{
    internal sealed class TravelerCheckListRepository : ITravelerCheckListRepository
    {
        private readonly DbSet<TravelerCheckList> _travelerCheckLists;
        private readonly WriteDBContext _writeDBContext;

        public TravelerCheckListRepository(DbSet<TravelerCheckList> travelerCheckLists, WriteDBContext writeDBContext)
        {
            _travelerCheckLists = travelerCheckLists;
            _writeDBContext = writeDBContext;
        }

        public async Task AddAsync(TravelerCheckList travelerCheckList)
        {
            await _travelerCheckLists.AddAsync(travelerCheckList);
            await _writeDBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TravelerCheckList travelerCheckList)
        {
            _travelerCheckLists?.Remove(travelerCheckList);
            await _writeDBContext.SaveChangesAsync();

        }

        public Task<TravelerCheckList> GetAsync(TravelerCheckListId id) =>
            _travelerCheckLists.Include("_items").SingleOrDefaultAsync(pl => pl.Id == id);

        public async Task UpdateAsync(TravelerCheckList travelerCheckList)
        {
            _travelerCheckLists.Update(travelerCheckList);
            await _writeDBContext.SaveChangesAsync();
        }
    }
}
