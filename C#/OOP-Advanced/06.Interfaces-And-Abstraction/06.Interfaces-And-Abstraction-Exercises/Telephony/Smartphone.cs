using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IDialable, IBrowsable
    {
        public void DialNumber(string phoneNumber)
        {
            if (!phoneNumber.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine($"Calling... {phoneNumber}");
        }

        public void BrowseUrl(string url)
        {
            if (url.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
                return;
            }

            Console.WriteLine($"Browsing: {url}!");
        }
    }
}
