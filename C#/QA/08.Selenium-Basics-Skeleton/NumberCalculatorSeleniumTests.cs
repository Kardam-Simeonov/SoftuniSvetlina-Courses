using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsProject
{
    public class NumberCalculatorSeleniumTests
    {
        IWebDriver driver;
        IWebElement textBoxFirstNum;
        IWebElement textBoxSecondNum;
        IWebElement dropDownOperation;
        IWebElement calculatiomButton;
        IWebElement resetButton;
        IWebElement divResult;

        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
            this.driver.Url = "https://number-calculator.nakov.repl.co";
            this.textBoxFirstNum = this.driver.FindElement(By.Id("number1"));
            this.textBoxSecondNum = this.driver.FindElement(By.Id("number1"));
            this.dropDownOperation = this.driver.FindElement(By.Id("operation"));
            this.calculatiomButton = this.driver.FindElement(By.Id("calcButton"));
            this.resetButton = this.driver.FindElement(By.Id("resetButton"));
            this.divResult = this.driver.FindElement(By.Id("result"));
        }

        // Valid Integers
        // Infinity
        // Invalid Inputs
        // Invalid Operators
        public void Test_CalculatorWebApp(string num1,
                                          string op,
                                          string num2,
                                          string expected)
        {
            resetButton.Click();
            textBoxFirstNum.SendKeys(num1);
            dropDownOperation.SendKeys(op);
            textBoxSecondNum.SendKeys(num2);

            calculatiomButton.Click();

            string actualResult = divResult.Text;
            Assert.AreEqual(expected, actualResult);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            this.driver.Quit();
        }
    }
}
