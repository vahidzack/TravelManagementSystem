using TravelManagementSystem.Application.DTO.External;
using TravelManagementSystem.Application.DTO.External.TravelManagementSystem.Application.DTO.External;
using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDTO> GetWeatherAsync(Destination localization);
    }
}
