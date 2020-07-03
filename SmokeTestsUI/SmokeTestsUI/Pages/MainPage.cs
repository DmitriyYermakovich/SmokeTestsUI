using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Helper;

namespace Tests.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By SignInWithEmailBtnLocator = By.CssSelector(".action.default.medium.default.action");
        By TypingYourEmailFieldLocator = By.CssSelector(".authorization-form-wrapper [type='email']");
        By TypingPasswordFieldLocator = By.CssSelector(".authorization-form-wrapper [type='password']");
        By SignInBtnLocator = By.CssSelector("[value='sign-in']");
        By TypingNameOrNicknameFieldLocator = By.CssSelector("div.input-container [type='text']");
        By TypingReadEmailFieldLocator = By.CssSelector("div.input-container [type='email'].data.has-description");
        By TypingNewPasswordFieldLocator = By.CssSelector(".input-container [validations='isNotEmpty,minLength:4']");
        By CreateAccountBtnLocator = By.CssSelector(".action.call-to-action.medium[value='sign-up']");
        By CreateYourAccountLocator = By.CssSelector("div.react-footer");
        #endregion

        #region Methods
        public MainPage ClickSignInWithEmailBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(SignInWithEmailBtnLocator)).Click();
            return this;
        }

        public MainPage TypingYourEmailField(string email)
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(TypingYourEmailFieldLocator)).SendKeys(email);
            return this;
        }

        public MainPage TypingPasswordField(string password)
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(TypingPasswordFieldLocator)).SendKeys(password);
            return this;
        }

        public MainPage ClickSignInBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(SignInBtnLocator)).Click();
            return this;
        }

        public MainPage ClickCreateYourAccountBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CreateYourAccountLocator)).Click();
            return this;
        }

        public MainPage TypingNameOrNicknameField()
        {
            var nickname = "Test user";

            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(TypingNameOrNicknameFieldLocator)).SendKeys(nickname);
            return this;
        }

        public MainPage TypingReadEmailField()
        {
            var reademail = new GenerateTestEmail(Browser).GenerateNewTestEmail();
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(TypingReadEmailFieldLocator)).SendKeys(reademail);
            return this;
        }

        public MainPage TypingNewPasswordField()
        {
            var newpassword = "654321";

            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(TypingNewPasswordFieldLocator)).SendKeys(newpassword);
            return this;
        }

        public AboutYouFormPage ClickCreateAccountBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CreateAccountBtnLocator)).Click();
            return new AboutYouFormPage(Browser);
        }
        #endregion
    }

}