using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Pages
{
    public class FewWordsFormPage : BasePage
    {
        public FewWordsFormPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By ApproveBigBtnLocator = By.CssSelector("form.few-words-form .complete-button-section button.approve");
        #endregion

        #region Methods
        public PreferencesFormPage ApproveBigBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(ApproveBigBtnLocator)).Click();
            return new PreferencesFormPage(Browser);
        }
        #endregion
    }
}
