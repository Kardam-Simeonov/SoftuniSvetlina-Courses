using System;
using System.Collections.Generic;
using System.Text;

namespace EventCalculator
{
    public class AddTwoNumbers
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler OddNumberEvent;


        public void Add(int a, int b)
        {
            int sum = a + b;

            Console.WriteLine(sum);
            
            if (sum % 2 != 0 && OddNumberEvent != null)
                OddNumberEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
