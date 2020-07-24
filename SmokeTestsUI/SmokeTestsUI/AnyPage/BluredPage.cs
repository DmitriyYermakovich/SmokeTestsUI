using OpenQA.Selenium;
using Tests.Pages;
using OpenQA.Selenium.Support.UI;

namespace AnyPage
{
    class BluredPage : BasePage
    {
       public BluredPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By SandwichInPopupLocator = By.CssSelector(".icon.sandwich");
        By MenuProfileLocator = By.CssSelector(".link [url='/texts/header/menu#profile']");
        By PopupControlUnknownLocator = By.CssSelector(".button.popup-trigger .unknown.text");
        By UpgadeAccountBtnLocator = By.CssSelector(".subscribe.option");
        By NoticePurchaseMembershipLocator = By.CssSelector(".membership [url='/texts/forms/purchase/purchase#member']");
        By NoticePurchasedCreditsLocator = By.CssSelector("[url = '/texts/forms/purchase/purchase#purchased-credits']");
        #endregion

        #region Methods
        public BluredPage ClickSandwichInPopup()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(60))
                .Until(d => d.FindElement(SandwichInPopupLocator)).Click();
            return this;
        }

        public BluredPage ClickMenuProfile()
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

        public BluredPage ClickUpgadeAccountBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(UpgadeAccountBtnLocator)).Click();
            return this;
        }

        public bool IsNoticePurchaseMembershipDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NoticePurchaseMembershipLocator)).Displayed;
        }

        public bool IsNoticePurchasedCreditsDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NoticePurchasedCreditsLocator)).Displayed;
        }

        public ProfilePage GoToUserProfilePage(string userId)
        {
            Browser.Navigate().GoToUrl(PeoplePageUrl + "/#" + userId);
            return new ProfilePage(Browser);
        }
        #endregion
    }
}
