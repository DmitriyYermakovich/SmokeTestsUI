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
            var baseSiteUrl = "https://www.dating.030.npdev.lan";

            Browser = new ChromeDriver();
            Browser.Manage().Window.Maximize();
            //Browser.Navigate().GoToUrl("https://www.dating.com/");
            Browser.Navigate().GoToUrl(baseSiteUrl);
        }

        [TearDown]
        public void DoAfterAnyTest()
        {
            Browser.Quit();
        }
    }
}
