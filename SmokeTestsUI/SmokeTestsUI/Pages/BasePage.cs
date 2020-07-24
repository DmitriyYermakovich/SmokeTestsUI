using System;
using OpenQA.Selenium;

namespace Tests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Browser;
        protected static string BaseUrl= "https://www.dating.030.npdev.lan";
        protected string PeoplePageUrl = BaseUrl + "/people";

        public BasePage(IWebDriver Browser)
        {
            this.Browser = Browser;
        }

        protected TimeSpan TimeToWait = TimeSpan.FromSeconds(20);
    }
}
