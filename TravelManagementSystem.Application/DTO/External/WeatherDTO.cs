using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagementSystem.Application.DTO.External
{


    public class WeatherApiResponse
    {
        public CurrentWeather Current { get; set; }
    }

    public class CurrentWeather
    {
        public double TempC { get; set; }
        public int Humidity { get; set; }
        public Condition Condition { get; set; }
    }

    public class Condition
    {
        public string Text { get; set; }
    }

    namespace TravelManagementSystem.Application.DTO.External
    {
        public record WeatherDTO(double Temperature, int Humidity, string Description);
    }

}
