using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{

    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Browser;
        protected IWebDriver BrowserTwo;

        [SetUp]
        public void DoBeforeAnyTest()
        {
            var baseSiteUrl = "https://www.dating.030.npdev.lan";
            var baseSiteUrlTwo = "https://www.dating.030.npdev.lan";

            Browser = new ChromeDriver();                                                               
            Browser.Manage().Window.Maximize();
            //Browser.Navigate().GoToUrl("https://www.dating.com/");
            Browser.Navigate().GoToUrl(baseSiteUrl);

            BrowserTwo = new ChromeDriver();
            BrowserTwo.Manage().Window.Maximize();
            BrowserTwo.Navigate().GoToUrl(baseSiteUrlTwo);
        }

        [TearDown]
        public void DoAfterAnyTest()
        {
            Browser.Quit();
            BrowserTwo.Quit();
        }
    }
}
