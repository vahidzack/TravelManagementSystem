using System.Text.Json;
using TravelManagementSystem.Application.DTO.External;
using TravelManagementSystem.Application.DTO.External.TravelManagementSystem.Application.DTO.External;
using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Application.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _weatherApiBaseUrl = "http://api.weatherapi.com/v1/current.json";

        public WeatherService(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public async Task<WeatherDTO> GetWeatherAsync(Destination localization)
        {
            var url = $"{_weatherApiBaseUrl}?key={_apiKey}&q={localization.City},{localization.Country}";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Weather API request failed with status code {response.StatusCode}");
            }

            var responseBody = await response.Content.ReadAsStringAsync();
            WeatherApiResponse weatherResponse;
            try
            {
                weatherResponse = JsonSerializer.Deserialize<WeatherApiResponse>(responseBody);
            }
            catch (JsonException)
            {
                throw new HttpRequestException("Failed to deserialize the weather API response.");
            }

            var weatherDto = new WeatherDTO(
                Temperature: weatherResponse.Current.TempC,
                Humidity: weatherResponse.Current.Humidity,
                Description: weatherResponse.Current.Condition.Text
            );

            return weatherDto;
        }
    }
}
