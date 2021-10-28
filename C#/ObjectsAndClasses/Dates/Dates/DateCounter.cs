using System;
using System.Linq;

namespace Dates
{
    internal class DateCounter
    {
        public int CalculateDifference(string dateOne, string dateTwo)
        {
            int[] dateOneArray = dateOne.Split("/").Select(int.Parse).ToArray();
            DateTime dateTimeOne = new DateTime(dateOneArray[0], dateOneArray[1], dateOneArray[2]);

            int[] dateTwoArray = dateTwo.Split("/").Select(int.Parse).ToArray();
            DateTime dateTimeTwo = new DateTime(dateTwoArray[0], dateTwoArray[1], dateTwoArray[2]);

            return Math.Abs((dateTimeOne - dateTimeTwo).Days);
        }
    }
}