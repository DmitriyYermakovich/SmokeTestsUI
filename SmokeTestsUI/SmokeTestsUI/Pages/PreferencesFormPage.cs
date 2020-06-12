using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Pages
{
   public class PreferencesFormPage : BasePage
    {
        public PreferencesFormPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By ApproveBigTwoBtnLocator = By.CssSelector(".form.preferences-form div.complete-button-section .big.approve.button");
        #endregion

        #region Methods
        public InterestsFormPage ClickApproveBigTwoBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(ApproveBigTwoBtnLocator)).Click();
            return new InterestsFormPage(Browser);
        }
        #endregion
    }
}
