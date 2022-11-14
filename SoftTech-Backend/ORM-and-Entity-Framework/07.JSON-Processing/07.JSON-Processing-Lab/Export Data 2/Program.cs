using System.Text.Json;

namespace Import_Data_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonInput = File.ReadAllText("../../../InputWeather.txt");
            WeatherForcast forcast = JsonSerializer.Deserialize<WeatherForcast>(jsonInput);

            Console.WriteLine(forcast.Date);
            Console.WriteLine(forcast.TemperatureC);
            Console.WriteLine(forcast.Summary);
        }
    }
    public class WeatherForcast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}