using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Tests.Pages;
using Helper;

namespace AnyPage
{
    public class PurchaseForm : BasePage
    {
        public PurchaseForm(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By ChoiceCreditpack150Locator = By.CssSelector(".package.with-membership.is-discount");
        By CardNumberLocator = By.CssSelector(".data.card-number-field");
        By CardExpirationMonthLocator = By.CssSelector(".data.month [name = 'month'] [value = '3']");
        By CardExpirationYearLocator = By.CssSelector(".data.year [name = 'year'] [value = '2021']");
        By CardCVVFieldLocator = By.CssSelector(".data.card-cvv-input");
        By CardHolderFieldLocator = By.CssSelector(".input-container [id = 'cardholder']");
        By PurchaseCreditsBtnLocator = By.CssSelector(".row.button-wrapper");
        #endregion

        #region Methods
        public PurchaseForm ChoiceCreditpack150()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(ChoiceCreditpack150Locator)).Click();
            return this;
        }

        public PurchaseForm TypingVisaCardNumber()
        {
            var visanumber = new GenerateCardNumber(Browser).GenerateVisaCardNumber();
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardNumberLocator)).SendKeys(visanumber);
            return this;
        }

        public PurchaseForm SelectCardExpirationMonth()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardExpirationMonthLocator)).Click();
            return this;
        }

        public PurchaseForm SelectCardExpirationYear()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardExpirationYearLocator)).Click();
            return this;
        }
        public PurchaseForm TypingCardCVV()
        {
            var cvv = new GenerateRandomInt(Browser).GetRandomInt(3);
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardCVVFieldLocator)).SendKeys(cvv);
            return this;
        }

        public PurchaseForm TypingCardHolder()
        {
            var cardholder = new GenerateRandomString(Browser).GetRandomString(20);
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardHolderFieldLocator)).SendKeys(cardholder);
            return this;
        }

        public PurchaseForm ClickPurchaseCreditsBtn()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(PurchaseCreditsBtnLocator)).Click();
            return this;
        }
        #endregion
    }
}