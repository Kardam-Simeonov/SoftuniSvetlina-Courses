using System;
using System.Linq;

namespace Difference
{
    public class DateDifferenceCalculator
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public DateTime SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }


        public DateTime FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }

        public DateDifferenceCalculator(string firstInput, string secondInput)
        {
            int[] firstArr = firstInput.Split(" ").Select(int.Parse).ToArray();
            int[] secondArr = secondInput.Split(" ").Select(int.Parse).ToArray();

            FirstDate = new DateTime(firstArr[0], firstArr[1], firstArr[2]);
            SecondDate = new DateTime(secondArr[0], secondArr[1], secondArr[2]);
        }

        public void CalculateDifference()
        {
            Console.WriteLine(Math.Abs((firstDate - secondDate).TotalDays));
        }
    }
}