using System.Text.Json;

namespace Export_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherForcast myForcast = new();

            myForcast.Date = DateTime.Parse("2020-07-16");
            myForcast.TemperatureC = 30;
            myForcast.Summary = "Hot Summer Day";

            string weatherInfo = JsonSerializer.Serialize(myForcast);
            File.WriteAllText("myForcast.txt", weatherInfo);
        }
    }

    public class WeatherForcast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}