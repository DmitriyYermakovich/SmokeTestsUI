using System;
using OpenQA.Selenium;

namespace Tests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Browser;

        public BasePage(IWebDriver Browser)
        {
            this.Browser = Browser;
        }

        protected TimeSpan TimeToWait = TimeSpan.FromSeconds(10);
    }
}
