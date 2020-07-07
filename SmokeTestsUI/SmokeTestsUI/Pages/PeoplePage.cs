using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Helper;

namespace Tests.Pages
{
    public class PeoplePage : BasePage
    {
        public PeoplePage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By RefillAccountBtnLocator = By.CssSelector(".purchase.option [data-user-interaction-action-id='purchase.menu']");
        By IsTo150CreditsAfterPurchaseLocator = By.CssSelector(".credits-container .button.shady.small.credits-refill.high .amount.credits-amount");
        #endregion

        #region Methods
        public bool BtnRefillAccountDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(RefillAccountBtnLocator)).Displayed;
        }

        public bool IsTo150CreditsAfterPurchase()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(IsTo150CreditsAfterPurchaseLocator)).Displayed;
        }
        #endregion
    }
}
 