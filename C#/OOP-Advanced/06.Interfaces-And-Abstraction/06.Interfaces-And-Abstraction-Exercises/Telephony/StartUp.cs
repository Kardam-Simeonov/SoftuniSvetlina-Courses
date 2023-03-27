using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] urls = Console.ReadLine().Split(" ");

            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            foreach (string number in phoneNumbers)
            {
                if (number.Length == 10)
                    smartphone.DialNumber(number);

                else
                    stationaryPhone.DialNumber(number);
            }

            foreach (string url in urls)
            {
                smartphone.BrowseUrl(url);
            }
        }
    }
}
