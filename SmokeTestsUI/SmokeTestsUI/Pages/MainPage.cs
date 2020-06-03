using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By SignInWithEmailBtnLocator = By.CssSelector(".action.default.medium.default.action");
        By YourEmailFieldLocator = By.CssSelector(".authorization-form-wrapper [type='email']");
        By PasswordFieldLocator = By.CssSelector(".authorization-form-wrapper [type='password']");
        By SignInBtnLocator = By.CssSelector("[value='sign-in']");
        By NameOrNicknameFielddLocator = By.CssSelector("div.input-container [type='text']");
        By ReadEmailFieldLocator = By.CssSelector("div.input-container [type='email'].data.has-description");
        By NewPasswordFieldLocator = By.CssSelector(".input-container [validations='isNotEmpty,minLength:4']");
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

        public MainPage YourEmailField(string email)
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(YourEmailFieldLocator)).SendKeys(email);
            return this;
        }

        public MainPage PasswordField(string password)
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PasswordFieldLocator)).SendKeys(password);
            return this;
        }

        public MainPage SignInBtn()
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

        public MainPage NameOrNicknameField()
        {
            var nickname = "Test user";

            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NameOrNicknameFielddLocator)).SendKeys(nickname);
            return this;
        }

        public MainPage ReadEmailField()
        {
            var reademail = new GenerateTestEmail(Browser).GenerateNewTestEmail();
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(ReadEmailFieldLocator)).SendKeys(reademail);
            return this;
        }

public MainPage NewPasswordField()
        {
            var newpassword = "654321";

            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NewPasswordFieldLocator)).SendKeys(newpassword);
            return this;
        }

        public AboutYouFormPage CreateAccountBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CreateAccountBtnLocator)).Click();
            return new AboutYouFormPage(Browser);
        }
        #endregion
    }

}