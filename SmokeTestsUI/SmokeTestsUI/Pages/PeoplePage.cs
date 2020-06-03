using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Pages
{
    public class PeoplePage : BasePage
    {
        public PeoplePage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By SandwichInPopupLocator = By.CssSelector(".icon.sandwich");
        By MenuProfileLocator = By.CssSelector(".link [url='/texts/header/menu#profile']");
        By PopupControlUnknownLocator = By.CssSelector(".button.popup-trigger .unknown.text");
        #endregion

        #region Methods
        public PeoplePage SandwichInPopup()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(30))
                .Until(d => d.FindElement(SandwichInPopupLocator)).Click();
            return this;
        }

        public PeoplePage MenuProfile()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(MenuProfileLocator)).Click();
            return this;
        }

        public bool ClickPopupControlUnknownDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PopupControlUnknownLocator)).Displayed;
        }
        #endregion
    }
}
