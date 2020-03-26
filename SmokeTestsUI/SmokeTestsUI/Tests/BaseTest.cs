using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Browser;

        [SetUp]
        public void DoBeforeAnyTest()
        {
            Browser = new ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.dating.com/");
        }

        [TearDown]
        public void DoAfterAnyTest()
        {
            Browser.Quit();
        }
    }
}
