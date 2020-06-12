using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests.Pages
{
    public class PeoplePage : BasePage
    {
        public PeoplePage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By SandwichInPopupLocator = By.CssSelector(".icon.sandwich");
        By MenuProfileLocator = By.CssSelector(".link [url='/texts/header/menu#profile']");
        By PopupControlUnknownLocator = By.CssSelector(".button.popup-trigger .unknown.text");
        By FirstPurchaseLocator = By.CssSelector(".subscribe.option");
        By CardNumberFieldLocator = By.CssSelector(".data.card-number-field");
        By CardMonthFieldLocator = By.CssSelector(".data.month [name='month']");
        By CardMonthChoiceLocator = By.CssSelector(".data.month [name = 'month'] [value = '3']");
        By CardYearFieldLocator = By.CssSelector(".data.year [name = 'year']");
        By CardYearChoiceLocator = By.CssSelector(".data.year [name = 'year'] [value = '2021']");
        By CardCVVFieldLocator = By.CssSelector(".data.card-cvv-input");
        By CardHolderFieldLocator = By.CssSelector(".input-container [id = 'cardholder']");
        By PurchaseCreditsBtnLocator = By.CssSelector(".row.button-wrapper");
        By RefillAccountBtnLocator = By.CssSelector(".purchase.option [data-user-interaction-action-id='purchase.menu']");
        #endregion

        #region Methods
        public PeoplePage ClickSandwichInPopup()
        {
            new WebDriverWait(Browser, System.TimeSpan.FromSeconds(30))
                .Until(d => d.FindElement(SandwichInPopupLocator)).Click();
            return this;
        }

        public PeoplePage ClickMenuProfile()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(MenuProfileLocator)).Click();
            return this;
        }

        public bool ClickPopupControlUnknownDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PopupControlUnknownLocator)).Displayed;
        }

        public PeoplePage ClickUpgadeAccountBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(FirstPurchaseLocator)).Click();
            return this;
        }

        public PeoplePage VisaCardNumber()
        {
            var visanumber = new GenerateCardNumber(Browser).GenerateVisaCardNumber();
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardNumberFieldLocator)).SendKeys(visanumber);
            return this;
        }

        public PeoplePage CardMonthField()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardMonthFieldLocator)).Click();
            return this;
        }

        public PeoplePage CardMonthChoice()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardMonthChoiceLocator)).Click();
            return this;
        }

        public PeoplePage CardYearField()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardYearFieldLocator)).Click();
            return this;
        }

        public PeoplePage CardYearChoice()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardYearChoiceLocator)).Click();
            return this;
        }

        public PeoplePage CardCVV()
        {
            var cvv = new GenerateCardCVV(Browser).GenerateNewCardCVV();
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardCVVFieldLocator)).SendKeys(cvv);
            return this;
        }

        public PeoplePage CardHolder()
        {
            var cardholder = new GenerateCardHolder(Browser).GenerateNewCardHolder();
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardHolderFieldLocator)).SendKeys(cardholder);
            return this;
        }

        public PeoplePage ClickPurchaseCreditsBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PurchaseCreditsBtnLocator)).Click();
            return this;
        }

        public bool BtnRefillAccountDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(RefillAccountBtnLocator)).Displayed;
        }
        #endregion
    }
}