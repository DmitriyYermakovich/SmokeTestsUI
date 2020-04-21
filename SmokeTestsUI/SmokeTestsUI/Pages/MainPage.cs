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
        By MonthChoiceLocator = By.CssSelector(".customized-select [name='month'] [value='1']");
        By DayLocator = By.CssSelector(".customized-select [name='day']");
        By DayChoiceLocator = By.CssSelector(".customized-select [name = 'day'] [value = '10']");
        By YearLocator = By.CssSelector(".customized-select [name='year']");
        By YearChoiceLocator = By.CssSelector(".customized-select [name = 'year'] [value = '1950']");
        By NextBtnLocator = By.CssSelector(".big.approve.button.normal");
        //Кнопки Approve при регистрациии пользователя
        By ApproveBigBtnLocator = By.CssSelector("form.few-words-form .complete-button-section button.approve");
        By ApproveBigTwoBtnLocator = By.CssSelector(".form.preferences-form div.complete-button-section .big.approve.button");
        By ApproveBitBtnLocator = By.CssSelector(".form.interests-form .complete-button-section .bit.approve.button");
        By PhotosFormApproveBtnLocator = By.CssSelector(".form.photos-form .big.approve.button");

        By PopupControlUnknownLocator = By.CssSelector(".button.popup-trigger .unknown.text");

        By AboutYouFormYourGenderLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#gender-empty']");
        By AboutYouFormGenderPreferenceLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#preferences-empty']");
        By AboutYouFormYourDateOfBirthLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#birthday-empty']");
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
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(200))
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
            var reademail = "testemail25@sdventures.com";

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

        public MainPage MonthChoice()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(MonthChoiceLocator)).Click();
            return this;
        }

        public MainPage Day()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(DayLocator)).Click();
            return this;
        }

        public MainPage DayChoice()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(DayChoiceLocator)).Click();
            return this;
        }

        public MainPage Year()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(YearLocator)).Click();
            return this;
        }

        public MainPage YearChoice()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(YearChoiceLocator)).Click();
            return this;
        }

        public MainPage NextBtn()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(NextBtnLocator)).Click();
            return this;
        }

        public MainPage ApproveBigBtn()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(ApproveBigBtnLocator)).Click();
            return this;
        }

        public MainPage ApproveBigTwoBtn()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(ApproveBigTwoBtnLocator)).Click();
            return this;
        }

        public MainPage ApproveBitBtn()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(20))
                .Until(d => d.FindElement(ApproveBitBtnLocator)).Click();
            return this;
        }

        public MainPage PhotosFormApproveBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PhotosFormApproveBtnLocator)).Click();
            return this;
        }

        public bool PopupControlUnknownDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PopupControlUnknownLocator)).Displayed;
        }

        public string AboutYouFormYourGender()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(AboutYouFormYourGenderLocator)).Text;
        }

        public bool AboutYouFormYourGenderDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(AboutYouFormYourGenderLocator)).Displayed;
        }

        public string AboutYouFormGenderPreference()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(AboutYouFormGenderPreferenceLocator)).Text;
        }

        public bool AboutYouFormGenderPreferenceDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(AboutYouFormGenderPreferenceLocator)).Displayed;
        }

        public string AboutYouFormYourDateOfBirth()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(AboutYouFormYourDateOfBirthLocator)).Text;
        }

        public bool AboutYouFormYourDateOfBirthDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(AboutYouFormYourDateOfBirthLocator)).Displayed;
        }
        #endregion
    }
}