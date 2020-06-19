using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Helper;

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
        By UpgadeAccountBtnLocator = By.CssSelector(".subscribe.option");
        By CardNumberLocator = By.CssSelector(".data.card-number-field");
        By CardExpirationMonthLocator = By.CssSelector(".data.month [name = 'month'] [value = '3']");
        By CardExpirationYearLocator = By.CssSelector(".data.year [name = 'year'] [value = '2021']");
        By CardCVVFieldLocator = By.CssSelector(".data.card-cvv-input");
        By CardHolderFieldLocator = By.CssSelector(".input-container [id = 'cardholder']");
        By PurchaseCreditsBtnLocator = By.CssSelector(".row.button-wrapper");
        By RefillAccountBtnLocator = By.CssSelector(".purchase.option [data-user-interaction-action-id='purchase.menu']");
        By NoticePurchaseMembershipLocator = By.CssSelector(".membership [url='/texts/forms/purchase/purchase#member']");
        By NoticePurchasedCreditsLocator = By.CssSelector("[url = '/texts/forms/purchase/purchase#purchased-credits']");
        By AccrualCreditsAfterPurchaseLocator = By.CssSelector(".credits-container .button.shady.small.credits-refill.high .amount.credits-amount");
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
                .Until(d => d.FindElement(UpgadeAccountBtnLocator)).Click();
            return this;
        }

        public PeoplePage TypingVisaCardNumber()
        {
            var visanumber = new GenerateCardNumber(Browser).GenerateVisaCardNumber();
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardNumberLocator)).SendKeys(visanumber);
            return this;
        }

        public PeoplePage SelectCardExpirationMonth()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardExpirationMonthLocator)).Click();
            return this;
        }

        public PeoplePage SelectCardExpirationYear()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardExpirationYearLocator)).Click();
            return this;
        }
        public PeoplePage TypingCardCVV()
        {
            var cvv = new GenerateRandomNumber(Browser).GetRandomNumber(3);
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(CardCVVFieldLocator)).SendKeys(cvv);
            return this;
        }

        public PeoplePage TypingCardHolder()
        {
            var cardholder = new GenerateRandomLetter(Browser).GetRandomLetter(20);
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

        public bool GetNoticePurchaseMembershipDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NoticePurchaseMembershipLocator)).Displayed;
        }

        public bool GetNoticePurchasedCreditsDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(NoticePurchasedCreditsLocator)).Displayed;
        }
        public bool AccrualCreditsAfterPurchase()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(AccrualCreditsAfterPurchaseLocator)).Displayed;
        }
        #endregion
    }
}
 