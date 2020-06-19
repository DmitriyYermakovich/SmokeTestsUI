using OpenQA.Selenium;
using Tests.Pages;

namespace Helper
{
    class FirstPurchaser : BasePage
    {
        public FirstPurchaser(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        //Метод выполнения первой покупки клиентом
        public void FirstPurchaserClient()
        {
            new PeoplePage(Browser)
            
            .ClickUpgadeAccountBtn()
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