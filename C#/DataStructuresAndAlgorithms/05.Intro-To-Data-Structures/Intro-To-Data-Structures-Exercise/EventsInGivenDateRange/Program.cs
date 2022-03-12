using System;
using System.Globalization;
using System.Threading;
using Wintellect.PowerCollections;

namespace EventsInGivenDateRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var events = new OrderedMultiDictionary<DateTime, string>(true);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] eventTokens = Console.ReadLine().Split(" | ");
                string eventName = eventTokens[0];
                DateTime eventDate = DateTime.Parse(eventTokens[1]);
                events.Add(eventDate, eventName);
            }

            string[] datesTokens = Console.ReadLine().Split(" | ");
            DateTime startDate = DateTime.Parse(datesTokens[0]);
            DateTime endDate = DateTime.Parse(datesTokens[1]);
            var eventsInRange = events.Range(startDate, true, endDate, true);

            foreach (var dateTime in eventsInRange)
            {
                Console.WriteLine($"{dateTime.Value} | {dateTime.Key.ToString("dd-MMM-yyyy hh:mm")}");
            }
        }
    }
}
