using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Tests.Pages
{
    public class InterestsFormPage : BasePage
    {
        public InterestsFormPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By ApproveBitBtnLocator = By.CssSelector(".form.interests-form .complete-button-section .bit.approve.button");
        #endregion

        #region Methods
        public PhotosFormPage ClickApproveBitBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(ApproveBitBtnLocator)).Click();
            return new PhotosFormPage(Browser);
        }
        #endregion
    }
}