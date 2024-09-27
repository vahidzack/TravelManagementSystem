using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Application.Exceptions;
using TravelManagementSystem.Application.Services;
using TravelManagementSystem.Domain.Factories;
using TravelManagementSystem.Domain.Repositories;
using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands.Handlers
{
    public sealed class CreateTravelerCheckListWithItemsHandler : ICommandHandler<CreateTravelerCheckListWithItems>
    {
        private readonly ITravelerCheckListRepository _Repository;
        private readonly IWeatherService _weatherService;
        private readonly ITravelerCheckListFactory _factory;

        public CreateTravelerCheckListWithItemsHandler(ITravelerCheckListRepository repository, IWeatherService weatherService, ITravelerCheckListFactory factory)
        {
            _Repository = repository;
            _weatherService = weatherService;
            _factory = factory;
        }

        public async Task HandleAsync(CreateTravelerCheckListWithItems command)
        {
            var (id, name, days, gender, DestinationWriteWithModel) = command;

            var destination = new Destination(DestinationWriteWithModel.City, DestinationWriteWithModel.Country);
            var weather = await _weatherService.GetWeatherAsync(destination);
            if (weather is null)
            {
                throw new MissingDestinationWeatherException(destination);
            }
            var travelerCheckList = _factory.CreateWithDefaultItems(id, name, days, gender, weather.Temperature, destination);
            await _Repository.UpdateAsync(travelerCheckList);
        }
    }
}
