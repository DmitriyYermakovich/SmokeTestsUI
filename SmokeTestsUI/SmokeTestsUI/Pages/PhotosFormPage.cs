using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Tests.Pages
{
    public class PhotosFormPage : BasePage
    {
        public PhotosFormPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By PhotosFormApproveBtnLocator = By.CssSelector(".form.photos-form .big.approve.button");
        #endregion

        #region Methods
        public PeoplePage PhotosFormApproveBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PhotosFormApproveBtnLocator)).Click();
            return new PeoplePage(Browser);
        }
        #endregion
    }
}