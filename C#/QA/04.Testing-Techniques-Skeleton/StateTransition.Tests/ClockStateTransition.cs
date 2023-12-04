using DigitalClock;

using NUnit.Framework;

namespace StateTransition.Tests
{
    public class ClockStateTransition
    {
        public Clock clock = new Clock();

        [SetUp]
        public void Setup()
        {
            clock = new Clock();
        }

        [Test]
        public void Test_Time_Hour_CorrectSet()
        {
            // Act
            clock.PushMiddleButton();
            clock.PushTopButton(5);

            // Assert
            Assert.AreEqual(5, clock.Hour); 
        }

        [Test]
        public void Test_Time_Minutes_CorrectSet()
        {
            // Act
            clock.PushMiddleButton();  
            clock.PushTopButton(2);    
            clock.PushMiddleButton();  
            clock.PushTopButton(15);   

            // Assert
            Assert.AreEqual(15, clock.Minutes);
        }

        [Test]
        public void Test_Time_Month_CorrectSet()
        {
            // Act
            clock.PushBottomButton(); 
            clock.PushTopButton(6);   

            // Assert
            Assert.AreEqual(7, clock.Month); 

        }

        [Test]
        public void Test_Time_Day_CorrectSet()
        {
            // Act
            clock.PushBottomButton();
            clock.PushBottomButton(); 
            clock.PushTopButton(10); 

            // Assert
            Assert.AreEqual(11, clock.Day); 
        }

        [Test]
        public void Test_Time_Year_CorrectSet()
        {
            // Act
            clock.PushBottomButton();
            clock.PushBottomButton(); 
            clock.PushBottomButton();
            clock.PushTopButton(200); 

            // Assert
            Assert.AreEqual(1200, clock.Year);
        }

        [Test]
        public void Test_Time_SetAll_CorrectSet()
        {

            // Act
            clock.PushMiddleButton();
            clock.PushTopButton(5); 
            clock.PushMiddleButton(); 
            clock.PushTopButton(30); 
            clock.PushBottomButton(); 
            clock.PushTopButton(7);  
            clock.PushBottomButton(); 
            clock.PushTopButton(15);
            clock.PushBottomButton();
            clock.PushTopButton(5); 

            // Assert
            Assert.AreEqual(5, clock.Hour);
            Assert.AreEqual(30, clock.Minutes);
            Assert.AreEqual(16, clock.Day);
            Assert.AreEqual(8, clock.Month);
            Assert.AreEqual(1005, clock.Year);
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