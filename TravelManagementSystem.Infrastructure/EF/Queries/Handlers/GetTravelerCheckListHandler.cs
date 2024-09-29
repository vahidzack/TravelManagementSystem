using Microsoft.EntityFrameworkCore;
using TravelManagementSystem.Application.DTO;
using TravelManagementSystem.Application.Queries;
using TravelManagementSystem.Domain.Repositories;
using TravelManagementSystem.Infrastructure.EF.Contexts;
using TravelManagementSystem.Infrastructure.EF.Models;
using TravelManagementSystem.Shared.Abstraction.Queries;

namespace TravelManagementSystem.Infrastructure.EF.Queries.Handlers
{
    internal sealed class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDTO>
    {
        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;

        public GetTravelerCheckListHandler(ReadDBContext readDBContext) =>
            _travelerCheckList = readDBContext.travelerCheckList;

        public Task<TravelerCheckListDTO> HandleAsync(GetTravelerCheckList query) =>
            _travelerCheckList.
            Include(pl => pl.Items).
            Where(pl => pl.Id == query.Id).
            Select(pl => pl.AsDto()).AsNoTracking().SingleOrDefaultAsync();

    }
}
