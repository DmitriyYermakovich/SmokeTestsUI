using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        By SandwichInPopupLocator = By.CssSelector(".icon.sandwich");
        By MenuProfileLocator = By.CssSelector(".link [url='/texts/header/menu#profile']");
        By CreateYourAccountLocator = By.CssSelector("div.react-footer");
        By NameOrNicknameFielddLocator = By.CssSelector("div.input-container [type='text']");
        By ReadEmailFieldLocator = By.CssSelector("div.input-container [type='email'].data.has-description");
        By NewPasswordFieldLocator = By.CssSelector(".input-container [validations='isNotEmpty,minLength:4']");
        By CreateAccountBtnLocator = By.CssSelector(".action.call-to-action.medium[value='sign-up']");
        //Form "About You"
        By IconMalLocator = By.CssSelector(".gender [class='icon mal']");
        By IconFemLocator = By.CssSelector(".preferred-gender [class='icon fem']");
        By MonthLocator = By.CssSelector(".customized-select [name='month']");
        #endregion

        #region Methods
        public MainPage ClickSignInWithEmailBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(SignInWithEmailBtnLocator)).Click();
            return this;
        }

        public MainPage YourEmailField()
        {
            var email = "dcUMT_1581089986812_test@dating.com";

            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(YourEmailFieldLocator)).SendKeys(email);
            return this;
        }

        public MainPage PasswordField()
        {
            var password = "654321";

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

        public MainPage SandwichInPopup()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(100))
                .Until(d => d.FindElement(SandwichInPopupLocator)).Click();
            return this;
        }

        public MainPage MenuProfile()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(MenuProfileLocator)).Click();
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
            var reademail = "testemail1@sdventures.com";

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

        public MainPage CreateAccountBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CreateAccountBtnLocator)).Click();
            return this;
        }

        public MainPage IconMal()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(IconMalLocator)).Click();
            return this;
        }

         public MainPage IconFem()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(IconFemLocator)).Click();
            return this;
        }
        public MainPage Month()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(MonthLocator)).Click();
            return this;
        }
        #endregion
    }
}