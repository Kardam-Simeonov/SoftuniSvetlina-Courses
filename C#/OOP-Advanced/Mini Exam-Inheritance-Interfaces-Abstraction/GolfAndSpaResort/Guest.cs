using System;
using System.Collections.Generic;
using System.Text;

namespace GolfAndSpaResort
{
    public class Guest : Customer
    {
        public Guest(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void NewGuest()
        {
            Console.WriteLine($"Mr/Ms/Mrs {FirstName} {LastName} registers as a guest.");
        }
    }
}
