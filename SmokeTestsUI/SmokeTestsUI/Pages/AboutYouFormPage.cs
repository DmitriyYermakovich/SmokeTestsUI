using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests.Pages
{
    public class AboutYouFormPage : BasePage
    {
        public AboutYouFormPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By OwnGenderMalLocator = By.CssSelector(".gender [class='icon mal']");
        By PrefferedGenderFemaleLocator = By.CssSelector(".preferred-gender [class='icon fem']");
        By MonthOfBirthLocator = By.CssSelector(".customized-select [name='month'] [value='1']");
        By DayOfBirthLocator = By.CssSelector(".customized-select [name = 'day'] [value = '10']");
        By YearOfBirthLocator = By.CssSelector(".customized-select [name = 'year'] [value = '1950']");
        By NextBtnLocator = By.CssSelector(".big.approve.button.normal");
        By InvalidTextYouGenderOnAboutYouFormLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#gender-empty']");
        By InvalidTextGenderPreferenceOnAboutYouFormLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#preferences-empty']");
        By InvalidTextDateOfBirthOnAboutYouFormLocator = By.CssSelector(".error-notification [url='/texts/forms/errors#birthday-empty']");
        #endregion

        #region Methods
        public AboutYouFormPage SelectOwnGenderMal()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(OwnGenderMalLocator)).Click();
            return this;
        }

        public AboutYouFormPage SelectPrefferedGenderFemale()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PrefferedGenderFemaleLocator)).Click();
            return this;
        }

        public AboutYouFormPage SelectMonthOfBirth()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(MonthOfBirthLocator)).Click();
            return this;
        }

        public AboutYouFormPage SelectDayOfBirth()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(DayOfBirthLocator)).Click();
            return this;
        }

        public AboutYouFormPage SelectYearOfBirth()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(YearOfBirthLocator)).Click();
            return this;
        }

        public FewWordsFormPage ClickNextBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NextBtnLocator)).Click();
            return new FewWordsFormPage(Browser);
        }

        public string GetInvalidTextYouGenderOnAboutYouForm()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(InvalidTextYouGenderOnAboutYouFormLocator)).Text;
        }

        public bool GetInvalidTextYouGenderOnAboutYouFormDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(InvalidTextYouGenderOnAboutYouFormLocator)).Displayed;
        }

        public string GetInvalidTextGenderPreferenceOnAboutYouForm()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(InvalidTextGenderPreferenceOnAboutYouFormLocator)).Text;
        }

        public bool GetInvalidTextGenderPreferenceOnAboutYouFormDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(InvalidTextGenderPreferenceOnAboutYouFormLocator)).Displayed;
        }

        public string GetInvalidTextDateOfBirthOnAboutYouForm()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(InvalidTextDateOfBirthOnAboutYouFormLocator)).Text;
        }

        public bool GetInvalidTextDateOfBirthOnAboutYouFormDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(InvalidTextDateOfBirthOnAboutYouFormLocator)).Displayed;
        }
        #endregion
    }
}
 