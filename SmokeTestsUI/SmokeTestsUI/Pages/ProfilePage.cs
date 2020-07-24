using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Pages
{
    public class ProfilePage : BasePage
    {
        public ProfilePage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By UserIdStringLocator = By.CssSelector(".userid-text .id");
        By ClickChatNowBtnLocator = By.CssSelector(".few-words .attention.button.emblem.chat.send-message");
        #endregion

        #region Methods
        public string GetUserId()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(UserIdStringLocator)).Text;
        }

        public ProfilePage ClickChatNowBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(ClickChatNowBtnLocator)).Click();
            return new ProfilePage(Browser);
        }
        #endregion
    }
}