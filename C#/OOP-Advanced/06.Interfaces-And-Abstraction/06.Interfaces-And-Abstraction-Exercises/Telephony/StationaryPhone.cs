using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IDialable
    {
        public void DialNumber(string phoneNumber)
        {
            if (!phoneNumber.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
