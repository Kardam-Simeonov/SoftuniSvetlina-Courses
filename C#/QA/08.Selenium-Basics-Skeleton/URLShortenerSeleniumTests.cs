using System;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsProject
{
    public class URLShortenerSeleniumTests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }

        [Test]
        public void Test_HomePage_Valid()
        {
            // Arrange
            this.driver.Url = "https://shorturl.nakov.repl.co/";

            // Act
            var title = this.driver.Title;

            // Assert
            Assert.AreEqual("URL Shortener", title);
        }

        [Test]
        public void Test_AddUrl_Valid()
        {
            // Arrange
            this.driver.Url = "https://shorturl.nakov.repl.co/";
            string uniqueCode = DateTime.Now.Ticks.ToString();
            IWebElement addUrlButton = this.driver.FindElement(By.LinkText("Add URL"));
            IWebElement urlTextField = this.driver.FindElement(By.LinkText("url"));
            IWebElement shortCodeTextField = this.driver.FindElement(By.LinkText("code"));
            IWebElement createButton = this.driver.FindElement(By.CssSelector("button"));

            // Act 
            addUrlButton.Click();

            urlTextField.Click();
            urlTextField.SendKeys("https://www.youtube.com/");

            shortCodeTextField.Click();
            shortCodeTextField.Clear();
            shortCodeTextField.SendKeys(uniqueCode);

            createButton.Click();

            IWebElement link = this.driver.FindElement(
                By.LinkText($"https://shorturl.nakov.repl.co/go/{uniqueCode}"));
            Assert.IsTrue(link.Displayed);
        }

        [Test]
        public void Test_AddUrl_Invalid()
        {
        }

        [Test]
        public void Test_VisitUrl()
        {
            // Arrange
            this.driver.Url = "https://shorturl.nakov.repl.co/";
            string uniqueCode = DateTime.Now.Ticks.ToString();

            IWebElement addUrlButton = this.driver.FindElement(By.LinkText("Add URL"));
            IWebElement urlTextField = this.driver.FindElement(By.Name("url")); // Assuming the correct name attribute for the URL field
            IWebElement shortCodeTextField = this.driver.FindElement(By.Name("code")); // Assuming the correct name attribute for the code field
            IWebElement createButton = this.driver.FindElement(By.CssSelector("button"));

            addUrlButton.Click();
            urlTextField.SendKeys("https://www.example.com/");
            shortCodeTextField.SendKeys(uniqueCode);
            createButton.Click();

            // Act
            IWebElement link = this.driver.FindElement(By.LinkText($"https://shorturl.nakov.repl.co/go/{uniqueCode}"));
            link.Click();

            this.driver.SwitchTo().Window(this.driver.WindowHandles[1]);

            this.driver.Navigate().Refresh();

            // Assert
            IWebElement counterElement = this.driver.FindElement(By.CssSelector(".visit-counter"));
            int initialCount = int.Parse(counterElement.Text);

            this.driver.Navigate().Refresh();
            int updatedCount = int.Parse(counterElement.Text);

            Assert.Greater(updatedCount, initialCount);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            this.driver.Quit();
        }
    }
}
