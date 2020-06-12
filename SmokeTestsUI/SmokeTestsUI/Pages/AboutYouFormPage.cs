using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace /*SmokeTestsUI.Pages*/ Tests.Pages
{
    public class AboutYouFormPage : BasePage
    {
        public AboutYouFormPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By IconMalLocator = By.CssSelector(".gender [class='icon mal']");
        By IconFemLocator = By.CssSelector(".preferred-gender [class='icon fem']");
        By MonthLocator = By.CssSelector(".customized-select [name='month']");
        By MonthChoiceLocator = By.CssSelector(".customized-select [name='month'] [value='1']");
        By DayLocator = By.CssSelector(".customized-select [name='day']");
        By DayChoiceLocator = By.CssSelector(".customized-select [name = 'day'] [value = '10']");
        By YearLocator = By.CssSelector(".customized-select [name='year']");
        By YearChoiceLocator = By.CssSelector(".customized-select [name = 'year'] [value = '1950']");
        By NextBtnLocator = By.CssSelector(".big.approve.button.normal");
        By AboutYouFormYourGenderLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#gender-empty']");
        By AboutYouFormGenderPreferenceLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#preferences-empty']");
        By AboutYouFormYourDateOfBirthLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#birthday-empty']");
        #endregion

        #region Methods
        public AboutYouFormPage ClickIconMal()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(IconMalLocator)).Click();
            return this;
        }

        public AboutYouFormPage ClickIconFem()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(IconFemLocator)).Click();
            return this;
        }
        public AboutYouFormPage OpenDropdownListMonth()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(MonthLocator)).Click();
            return this;
        }

        public AboutYouFormPage MonthChoice()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(MonthChoiceLocator)).Click();
            return this;
        }

        public AboutYouFormPage OpenDropdownListDay()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(DayLocator)).Click();
            return this;
        }

        public AboutYouFormPage DayChoice()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(DayChoiceLocator)).Click();
            return this;
        }

        public AboutYouFormPage OpenDropdownListYear()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(YearLocator)).Click();
            return this;
        }

        public AboutYouFormPage YearChoice()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(YearChoiceLocator)).Click();
            return this;
        }

        public FewWordsFormPage ClickNextBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NextBtnLocator)).Click();
            return new FewWordsFormPage(Browser);
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