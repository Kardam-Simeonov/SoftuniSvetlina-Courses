using DigitalClock;

using NUnit.Framework;

namespace StateTransition.Tests
{
    public class ClockStateTransition
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Time_Hour_CorrectSet()
        {
        }

        [Test]
        public void Test_Time_Minutes_CorrectSet()
        {
        }

        [Test]
        public void Test_Time_Month_CorrectSet()
        {
        }

        [Test]
        public void Test_Time_Day_CorrectSet()
        {
        }

        [Test]
        public void Test_Time_Year_CorrectSet()
        {
        }

        [Test]
        public void Test_Time_SetAll_CorrectSet()
        {
        }

        private static string GetExpectedTime(
            int hour = 0,
            int minute = 0,
            int day = 1,
            int month = 1,
            int year = 1000)
        {
            return $"{hour:d2}:{minute:d2} / {day:d2}.{month:d2}.{year:d4}";
        }
    }
}
