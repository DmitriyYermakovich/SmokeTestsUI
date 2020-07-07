using OpenQA.Selenium;
using Tests.Pages;
using AnyPage;

namespace Helper
{
    class PurchaseCredits : BasePage
    {
        public PurchaseCredits(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        //Метод выполнения первой покупки клиентом
        public void PurchaseCreditsClient()
        {
            new BluredPage(Browser)
            .ClickUpgadeAccountBtn();

            new PurchaseForm(Browser)
            .ChoiceCreditpack150()
            .TypingVisaCardNumber()
            .SelectCardExpirationMonth()
            .SelectCardExpirationYear()
            .TypingCardCVV()
            .TypingCardHolder()
            .ClickPurchaseCreditsBtn();
        }
        #endregion
    }
}