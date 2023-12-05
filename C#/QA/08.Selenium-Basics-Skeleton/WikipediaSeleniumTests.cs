using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsProject
{
    public class WikipediaSeleniumTests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
            this.driver.Url = "https://www.wikipedia.org";
        }

        [Test]
        public void Test_SearchForQAInWikipedia()
        {
            // Act
            this.driver.FindElement(By.CssSelector("input#searchInput")).Click();
            this.driver.FindElement(By.CssSelector("input#searchInput")).SendKeys("QA");
            this.driver.FindElement(By.CssSelector("input#searchInput")).SendKeys(Keys.Enter);

            // Assert
            string expected = "https://en.wikipedia.org/wiki/QA";
            Assert.AreEqual(expected, this.driver.Url);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            this.driver.Quit();
        }
    }
}
